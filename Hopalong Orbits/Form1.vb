Option Strict On
Imports System.Math
Imports HopalongOrbit

Public Class Form1


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DrawOrbit(HopalongOrbit.Resize(HopalongOrbit.Orbit(CLng(_itrations_updown.Value)), New SizeF(_size_upDown.Value, _size_upDown.Value)))
        'Generareorbita(Me.BackgroundImage)
        Me.Refresh()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim diag As New SaveFileDialog
        diag.Filter = "PNG|*.png"
        diag.FileName = ""
        If diag.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            Me.BackgroundImage.Save(diag.FileName, Imaging.ImageFormat.Png)
        End If

    End Sub
    Dim r As New Random
    Public Sub DrawOrbit(ByVal Orbit As OrbitResult)
        If Me.BackgroundImage IsNot Nothing Then Me.BackgroundImage.Dispose()

        Me.BackgroundImage = New Bitmap(CInt(Math.Ceiling(Orbit.Size.Width)), CInt(Math.Ceiling(Orbit.Size.Height)), Drawing.Imaging.PixelFormat.Format32bppPArgb)
        Dim g As Graphics = Graphics.FromImage(Me.BackgroundImage)

        g.SmoothingMode = Drawing2D.SmoothingMode.None

        Dim cl As Color = Color.FromArgb(R.Next(0, 255), R.Next(0, 255), R.Next(0, 255))

        For i As Integer = 0 To Orbit.ListOfDots.Count - 1
            If i Mod 100000 = 0 Then cl = Color.FromArgb(R.Next(0, 255), R.Next(0, 255), R.Next(0, 255))
            g.FillRectangle(New SolidBrush(cl), New RectangleF(New PointF(Orbit.ListOfDots(i).X, Orbit.ListOfDots(i).Y), New SizeF(_pointsize_updown.Value, _pointsize_updown.Value)))
        Next

        g.Dispose()
    End Sub

End Class
