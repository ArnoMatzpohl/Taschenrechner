Public Class Form1
    Public Function RandomString(ByVal length As Integer) As String

        Dim A As String
        Dim B As String
        Dim C As String
        Dim D As String
        Dim E As String
        Dim F As String
        Dim G As String
        Dim H As String
        Dim I As String
        Dim J As String
        Dim K As String
        Dim L As String
        Dim M As String
        Dim N As String
        Dim O As String
        Dim P As String
        Dim Q As String
        Dim R As String
        Dim S As String
        Dim T As String
        Dim U As String
        Dim V As String
        Dim W As String
        Dim X As String
        Dim Y As String
        Dim Z As String

        Dim strb As New System.Text.StringBuilder
        Dim chars() As String = {A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0}

        Dim UpperBound As String = UBound(chars)

        For xx As Integer = 1 To 30
            strb.Append(chars(Int(Rnd() * UpperBound)))
        Next

        Return strb.ToString
    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim rndstring As String
        rndstring = RandomString(16)
        TextBox1.Text = rndstring
    End Sub

End Class
