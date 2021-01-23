Option Explicit On
Option Strict On
Option Infer On
Imports System.Windows.Forms
Module module1
    Public jm1 As String
    Public jm2 As String
    Sub Main()

        Dim fr As New Tiktok

        jm1 = InputBox("Zadejte jméno 1. hráče: ")
        If (jm1 = "") Then
            MsgBox("Chyba! Musíte zadat jméno")
        Else
            jm2 = InputBox("Zadejte jméno 2. hráče: ")
            If (jm2 <> "") Then
                fr.ShowDialog()
            Else
                MsgBox("Chyba! Musíte zadat jméno")
            End If
        End If
    End Sub

End Module
