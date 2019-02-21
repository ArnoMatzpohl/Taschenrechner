Imports System.Security.Cryptography

Public Class CurrentData

    Public Shared Property UserName As String
    Public Shared Property Password As String

    Public Shared Function Encrypt(value As String, password As String) As Byte()
        Dim byteDeriver As New Rfc2898DeriveBytes(password, Sha256(password))
        Dim aes As New AesManaged
        Dim encryptedStream As New IO.MemoryStream
        Dim valueBytes As Byte()

        valueBytes = Text.Encoding.Unicode.GetBytes(value)
        aes.IV = byteDeriver.GetBytes(16)
        aes.Key = byteDeriver.GetBytes(32)

        Using cs As New CryptoStream(encryptedStream, aes.CreateEncryptor, CryptoStreamMode.Write)
            cs.Write(valueBytes, 0, valueBytes.Length)
            cs.FlushFinalBlock()

            Return encryptedStream.ToArray
        End Using
    End Function

    Public Shared Function Decrypt(value As Byte(), password As String) As String
        Dim byteDeriver As New Rfc2898DeriveBytes(password, Sha256(password))
        Dim aes As New AesManaged
        Dim encryptedStream As New IO.MemoryStream(value)
        Dim decryptedStream As New IO.MemoryStream

        aes.IV = byteDeriver.GetBytes(16)
        aes.Key = byteDeriver.GetBytes(32)

        Using decryptedStream
            Using cs As New CryptoStream(encryptedStream, aes.CreateDecryptor, CryptoStreamMode.Read)
                cs.CopyTo(decryptedStream)
            End Using

            Return Text.Encoding.Unicode.GetString(decryptedStream.ToArray)
        End Using
    End Function

    Public Shared Function Sha256(value As String) As Byte()
        Dim sha As New SHA256Managed
        Dim valueBytes As Byte()

        valueBytes = Text.Encoding.Unicode.GetBytes(value)

        Return sha.ComputeHash(valueBytes)
    End Function

End Class
