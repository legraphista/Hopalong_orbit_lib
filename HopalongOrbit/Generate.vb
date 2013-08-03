Option Strict On
Imports System.Math
Imports System.Drawing

Public Module Generate
    Private R As New Random

    Public Function Orbit() As OrbitResult
        Return Orbit(R.NextDouble * R.Next(-500, 500), R.NextDouble * R.Next(-500, 500), R.NextDouble * R.Next(-500, 500), 0, 0, R.Next(20000, 200000))
    End Function

    Public Function Orbit(ByVal Sx As Double, ByVal Sy As Double) As OrbitResult
        Return Orbit(R.NextDouble * R.Next(-500, 500), R.NextDouble * R.Next(-500, 500), R.NextDouble * R.Next(-500, 500), Sx, Sy, R.Next(20000, 200000))
    End Function

    Public Function Orbit(ByVal A As Double, ByVal B As Double, ByVal C As Double) As OrbitResult
        Return Orbit(A, B, C, 0, 0, R.Next(20000, 200000))
    End Function

    Public Function Orbit(ByVal A As Double, ByVal B As Double, ByVal C As Double, ByVal Sx As Double, ByVal Sy As Double) As OrbitResult
        Return Orbit(A, B, C, Sx, Sy, R.Next(20000, 200000))
    End Function

    Public Function Orbit(ByVal Iterations As Long) As OrbitResult
        Return Orbit(R.NextDouble * R.Next(-500, 500), R.NextDouble * R.Next(-500, 500), R.NextDouble * R.Next(-500, 500), 0, 0, Iterations)
    End Function

    Public Function Orbit(ByVal A As Double, ByVal B As Double, ByVal C As Double, ByVal Sx As Double, ByVal Sy As Double, ByVal Iterations As Long) As OrbitResult
        Dim Lx, Ly, X, Y As Double
        Lx = Sx
        Ly = Sy

        Dim ListOfDots As New List(Of PointF)

        For i As Long = 0 To Iterations
            X = Ly - Sign(Lx) * Sqrt(Abs(B * Lx - C))
            Y = A - Lx
            Ly = Y
            Lx = X
            ListOfDots.Add(New PointF(CSng(X), CSng(Y)))
        Next

        Dim MinBound As New PointF(Single.MaxValue, Single.MaxValue), MaxBound As New PointF(Single.MinValue, Single.MinValue)

        For Each p As PointF In ListOfDots
            MinBound.X = If(MinBound.X > p.X, p.X, MinBound.X)
            MinBound.Y = If(MinBound.Y > p.Y, p.Y, MinBound.Y)
        Next
        For i As Integer = 0 To ListOfDots.Count - 1
            ListOfDots(i) = New PointF(ListOfDots(i).X - MinBound.X, ListOfDots(i).Y - MinBound.Y)
            MaxBound.X = If(MaxBound.X < ListOfDots(i).X, ListOfDots(i).X, MaxBound.X)
            MaxBound.Y = If(MaxBound.Y < ListOfDots(i).Y, ListOfDots(i).Y, MaxBound.Y)
        Next
        Return New OrbitResult(ListOfDots, New SizeF(MaxBound.X, MaxBound.Y))
    End Function

    Public Function Resize(ByVal result As OrbitResult, ByVal _size As SizeF) As OrbitResult
        Dim factor As New PointF
        factor.X = result.Size.Width / _size.Width
        factor.Y = result.Size.Height / _size.Height
        For i As Integer = 0 To result.ListOfDots.Count - 1
            result.ListOfDots(i) = New PointF(result.ListOfDots(i).X / factor.X, result.ListOfDots(i).Y / factor.Y)
        Next
        result.Size = _size
        Return result
    End Function
    Public Sub Resize_ByRef(ByRef result As OrbitResult, ByVal _size As SizeF)
        result = Resize(result, _size)
    End Sub

    Public Function Resize(ByVal result As OrbitResult, ByVal factor As Double) As OrbitResult
        Return Resize(result, New SizeF(CSng(result.Size.Width * factor), CSng(result.Size.Height * factor)))
    End Function
    Public Sub Resize_ByRef(ByRef result As OrbitResult, ByVal factor As Double)
        result = Resize(result, factor)
    End Sub

    Public Function DrawOrbit(ByVal Orbit As OrbitResult) As Bitmap
        Dim b As New Bitmap(CInt(Math.Ceiling(Orbit.Size.Width)), CInt(Math.Ceiling(Orbit.Size.Height)), Drawing.Imaging.PixelFormat.Format32bppPArgb)
        Dim g As Graphics = Graphics.FromImage(b)

        g.SmoothingMode = Drawing2D.SmoothingMode.None

        Dim cl As Color = Color.FromArgb(R.Next(0, 255), R.Next(0, 255), R.Next(0, 255))

        For i As Integer = 0 To Orbit.ListOfDots.Count - 1
            If i Mod 100000 = 0 Then cl = Color.FromArgb(R.Next(0, 255), R.Next(0, 255), R.Next(0, 255))
            g.FillRectangle(New SolidBrush(cl), New RectangleF(New PointF(Orbit.ListOfDots(i).X, Orbit.ListOfDots(i).Y), New SizeF(2, 2)))
        Next

        g.Dispose()

        DrawOrbit = CType(b.Clone, Bitmap)

        b.Dispose()
    End Function

    Public Sub DrawOrbit(ByVal Orbit As OrbitResult, ByRef b As Bitmap)
        If b IsNot Nothing Then b.Dispose()
        b = DrawOrbit(Orbit)
    End Sub

    Public Sub DrawOrbit(ByVal Orbit As OrbitResult, ByRef b As Image)
        If b IsNot Nothing Then b.Dispose()
        b = DrawOrbit(Orbit)
    End Sub
End Module
Public Structure OrbitResult
    Public ListOfDots As List(Of PointF)
    Public Size As SizeF
    Sub New(ByRef _list As List(Of PointF), ByVal _sz As SizeF)
        ListOfDots = New List(Of PointF)
        ListOfDots.AddRange(_list.ToArray)
        Size = _sz
    End Sub
    Public Function Clone() As OrbitResult
        Return New OrbitResult(ListOfDots, Size)
    End Function
    Public Sub Dispoze()
        ListOfDots.Clear()
    End Sub
End Structure