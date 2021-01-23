
Option Explicit On
Option Strict Off
Option Infer On
Imports System.Windows.Forms


Public Class Tiktok
    Dim novyFont, lbFont, hracFont, hracFont2, vysl As System.Drawing.Font
    Dim FontStyle As System.Drawing.FontStyle
    Private Sub Tiktok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        jmeno1.Text = jm1
        jmeno2.Text = jm2
        hracJmeno.Text = jm1
        vysledek.Text = ""
        novyFont = New System.Drawing.Font(tik.Font.SystemFontName, 36, FontStyle.Bold)
        lbFont = New System.Drawing.Font(lb1.Font.SystemFontName, 12, FontStyle.Bold)
        hracFont = New System.Drawing.Font(hracCislo.Font.SystemFontName, 12, FontStyle.Bold)
        hracFont2 = New System.Drawing.Font(hracJmeno.Font.SystemFontName, 12, FontStyle.Bold)
        vysl = New System.Drawing.Font(vysledek.Font.SystemFontName, 12, FontStyle.Bold)
        tik.Font = novyFont
        lb1.Font = lbFont
        hracCislo.Font = hracFont
        hracJmeno.Font = hracFont2
        vysledek.Font = vysl
    End Sub
    Dim i = 0
    Dim pr1 = 0
    Dim pr2 = 0
    Dim pr3 = 0
    Dim pr4 = 0
    Dim pr5 = 0
    Dim pr6 = 0
    Dim pr7 = 0
    Dim pr8 = 0
    Dim pr9 = 0
    Dim vyh1 = 0
    Dim vyh2 = 0
    Dim pocetH = 1
    'Dim jmenovec1 = jm1
    'Dim jmenovec2 = jm2



    Sub novy()
        pocetH += 1
        pocetHer.Text = pocetH.ToString + "."
        b1.Image = p3.Image
        b2.Image = p3.Image
        b3.Image = p3.Image
        b4.Image = p3.Image
        b5.Image = p3.Image
        b6.Image = p3.Image
        b7.Image = p3.Image
        b8.Image = p3.Image
        b9.Image = p3.Image
        pr1 = 0
        pr2 = 0
        pr3 = 0
        pr4 = 0
        pr5 = 0
        pr6 = 0
        pr7 = 0
        pr8 = 0
        pr9 = 0
        If (pocetH Mod 2 = 0) Then
            hracCislo.Text = "hráč č. 2: "
            hracJmeno.Text = jm2
        Else
            hracCislo.Text = "hráč č. 1: "
            hracJmeno.Text = jm1
        End If
    End Sub

    Sub vys1()
        If (pr1 = 1) And (pr2 = 1) And (pr3 = 1) Then
            MsgBox("Vyhrál hráč číslo 1 " + jm1)
            MsgBox("Pro další hru klikněte na ""HRAJTE DALŠÍ HRU""")
            vyh1 += 1
            vyhra1.Text = vyh1.ToString
            If (vyh1 > vyh2) Then
                vysledek.Text = "Vede hráč č. 1 " + jm1
            ElseIf (vyh1 < vyh2) Then
                vysledek.Text = "Vede hráč č. 2 " + jm2
            Else
                vysledek.Text = "remíza"
            End If

            i = 0
        End If

        If (pr4 = 1) And (pr5 = 1) And (pr6 = 1) Then
            MsgBox("Vyhrál hráč číslo 1 " + jm1)
            MsgBox("Pro další hru klikněte na ""HRAJTE DALŠÍ HRU""")
            vyh1 += 1
            vyhra1.Text = vyh1.ToString
            If (vyh1 > vyh2) Then
                vysledek.Text = "Vede hráč č. 1 " + jm1
            ElseIf (vyh1 < vyh2) Then
                vysledek.Text = "Vede hráč č. 2 " + jm2
            Else
                vysledek.Text = "remíza"
            End If
            i = 0
        End If

        If (pr7 = 1) And (pr8 = 1) And (pr9 = 1) Then
            MsgBox("Vyhrál hráč číslo 1 " + jm1)
            MsgBox("Pro další hru klikněte na ""HRAJTE DALŠÍ HRU""")
            vyh1 += 1
            vyhra1.Text = vyh1.ToString
            If (vyh1 > vyh2) Then
                vysledek.Text = "Vede hráč č. 1 " + jm1
            ElseIf (vyh1 < vyh2) Then
                vysledek.Text = "Vede hráč č. 2 " + jm2
            Else
                vysledek.Text = "remíza"
            End If
            i = 0
        End If

        If (pr1 = 1) And (pr4 = 1) And (pr7 = 1) Then
            MsgBox("Vyhrál hráč číslo 1 " + jm1)
            MsgBox("Pro další hru klikněte na ""HRAJTE DALŠÍ HRU""")
            vyh1 += 1
            vyhra1.Text = vyh1.ToString
            If (vyh1 > vyh2) Then
                vysledek.Text = "Vede hráč č. 1 " + jm1
            ElseIf (vyh1 < vyh2) Then
                vysledek.Text = "Vede hráč č. 2 " + jm2
            Else
                vysledek.Text = "remíza"
            End If
            i = 0
        End If

        If (pr2 = 1) And (pr5 = 1) And (pr8 = 1) Then
            MsgBox("Vyhrál hráč číslo 1 " + jm1)
            MsgBox("Pro další hru klikněte na ""HRAJTE DALŠÍ HRU""")
            vyh1 += 1
            vyhra1.Text = vyh1.ToString
            If (vyh1 > vyh2) Then
                vysledek.Text = "Vede hráč č. 1 " + jm1
            ElseIf (vyh1 < vyh2) Then
                vysledek.Text = "Vede hráč č. 2 " + jm2
            Else
                vysledek.Text = "remíza"
            End If
            i = 0
        End If

        If (pr3 = 1) And (pr6 = 1) And (pr9 = 1) Then
            MsgBox("Vyhrál hráč číslo 1 " + jm1)
            MsgBox("Pro další hru klikněte na ""HRAJTE DALŠÍ HRU""")
            vyh1 += 1
            vyhra1.Text = vyh1.ToString
            If (vyh1 > vyh2) Then
                vysledek.Text = "Vede hráč č. 1 " + jm1
            ElseIf (vyh1 < vyh2) Then
                vysledek.Text = "Vede hráč č. 2 " + jm2
            Else
                vysledek.Text = "remíza"
            End If
            i = 0
        End If

        If (pr1 = 1) And (pr5 = 1) And (pr9 = 1) Then
            MsgBox("Vyhrál hráč číslo 1 " + jm1)
            MsgBox("Pro další hru klikněte na ""HRAJTE DALŠÍ HRU""")
            vyh1 += 1
            vyhra1.Text = vyh1.ToString
            If (vyh1 > vyh2) Then
                vysledek.Text = "Vede hráč č. 1 " + jm1
            ElseIf (vyh1 < vyh2) Then
                vysledek.Text = "Vede hráč č. 2 " + jm2
            Else
                vysledek.Text = "remíza"
            End If
            i = 0
        End If

        If (pr3 = 1) And (pr5 = 1) And (pr7 = 1) Then
            MsgBox("Vyhrál hráč číslo 1 " + jm1)
            MsgBox("Pro další hru klikněte na ""HRAJTE DALŠÍ HRU""")
            vyh1 += 1
            vyhra1.Text = vyh1.ToString
            If (vyh1 > vyh2) Then
                vysledek.Text = "Vede hráč č. 1 " + jm1
            ElseIf (vyh1 < vyh2) Then
                vysledek.Text = "Vede hráč č. 2 " + jm2
            Else
                vysledek.Text = "remíza"
            End If
            i = 0
        End If
    End Sub
    Sub vys2()
        If (pr1 = 2) And (pr2 = 2) And (pr3 = 2) Then
            MsgBox("Vyhrál hráč číslo 2 " + jm2)
            MsgBox("Pro další hru klikněte na ""HRAJTE DALŠÍ HRU""")
            vyh2 += 1
            vyhra2.Text = vyh2.ToString
            If (vyh1 > vyh2) Then
                vysledek.Text = "Vede hráč č. 1 " + jm1
            ElseIf (vyh1 < vyh2) Then
                vysledek.Text = "Vede hráč č. 2 " + jm2
            Else
                vysledek.Text = "remíza"
            End If
            i = 0
        End If

        If (pr4 = 2) And (pr5 = 2) And (pr6 = 2) Then
            MsgBox("Vyhrál hráč číslo 2 " + jm2)
            MsgBox("Pro další hru klikněte na ""HRAJTE DALŠÍ HRU""")
            vyh2 += 1
            vyhra2.Text = vyh2.ToString
            If (vyh1 > vyh2) Then
                vysledek.Text = "Vede hráč č. 1 " + jm1
            ElseIf (vyh1 < vyh2) Then
                vysledek.Text = "Vede hráč č. 2 " + jm2
            Else
                vysledek.Text = "remíza"
            End If
            i = 0
        End If

        If (pr7 = 2) And (pr8 = 2) And (pr9 = 2) Then
            MsgBox("Vyhrál hráč číslo 2 " + jm2)
            MsgBox("Pro další hru klikněte na ""HRAJTE DALŠÍ HRU""")
            vyh2 += 1
            vyhra2.Text = vyh2.ToString
            If (vyh1 > vyh2) Then
                vysledek.Text = "Vede hráč č. 1 " + jm1
            ElseIf (vyh1 < vyh2) Then
                vysledek.Text = "Vede hráč č. 2 " + jm2
            Else
                vysledek.Text = "remíza"
            End If
            i = 0
        End If

        If (pr1 = 2) And (pr4 = 2) And (pr7 = 2) Then
            MsgBox("Vyhrál hráč číslo 2 " + jm2)
            MsgBox("Pro další hru klikněte na ""HRAJTE DALŠÍ HRU""")
            vyh2 += 1
            vyhra2.Text = vyh2.ToString
            If (vyh1 > vyh2) Then
                vysledek.Text = "Vede hráč č. 1 " + jm1
            ElseIf (vyh1 < vyh2) Then
                vysledek.Text = "Vede hráč č. 2 " + jm2
            Else
                vysledek.Text = "remíza"
            End If
            i = 0
        End If

        If (pr2 = 2) And (pr5 = 2) And (pr8 = 2) Then
            MsgBox("Vyhrál hráč číslo 2 " + jm2)
            MsgBox("Pro další hru klikněte na ""HRAJTE DALŠÍ HRU""")
            vyh2 += 1
            vyhra2.Text = vyh2.ToString
            If (vyh1 > vyh2) Then
                vysledek.Text = "Vede hráč č. 1 " + jm1
            ElseIf (vyh1 < vyh2) Then
                vysledek.Text = "Vede hráč č. 2 " + jm2
            Else
                vysledek.Text = "remíza"
            End If
            i = 0
        End If

        If (pr3 = 2) And (pr6 = 2) And (pr9 = 2) Then
            MsgBox("Vyhrál hráč číslo 2 " + jm2)
            MsgBox("Pro další hru klikněte na ""HRAJTE DALŠÍ HRU""")
            vyh2 += 1
            vyhra2.Text = vyh2.ToString
            If (vyh1 > vyh2) Then
                vysledek.Text = "Vede hráč č. 1 " + jm1
            ElseIf (vyh1 < vyh2) Then
                vysledek.Text = "Vede hráč č. 2 " + jm2
            Else
                vysledek.Text = "remíza"
            End If
            i = 0
        End If

        If (pr1 = 2) And (pr5 = 2) And (pr9 = 2) Then
            MsgBox("Vyhrál hráč číslo 2 " + jm2)
            MsgBox("Pro další hru klikněte na ""HRAJTE DALŠÍ HRU""")
            vyh2 += 1
            vyhra2.Text = vyh2.ToString
            If (vyh1 > vyh2) Then
                vysledek.Text = "Vede hráč č. 1 " + jm1
            ElseIf (vyh1 < vyh2) Then
                vysledek.Text = "Vede hráč č. 2 " + jm2
            Else
                vysledek.Text = "remíza"
            End If
            i = 0
        End If

        If (pr3 = 2) And (pr5 = 2) And (pr7 = 2) Then
            MsgBox("Vyhrál hráč číslo 2 " + jm2)
            MsgBox("Pro další hru klikněte na ""HRAJTE DALŠÍ HRU""")
            vyh2 += 1
            vyhra2.Text = vyh2.ToString
            If (vyh1 > vyh2) Then
                vysledek.Text = "Vede hráč č. 1 " + jm1
            ElseIf (vyh1 < vyh2) Then
                vysledek.Text = "Vede hráč č. 2" + jm2
            Else
                vysledek.Text = "remíza"
            End If
            i = 0
        End If
    End Sub


    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        If (pocetH Mod 2 <> 0) Then
            i += 1
            If (i Mod 2 <> 0) Then
                b1.Image = p1.Image
                pr1 = 1
            Else
                b1.Image = p2.Image
                pr1 = 2
            End If
            vys1()
            vys2()
        End If

        If (pocetH Mod 2 = 0) Then
            i += 1
            If (i Mod 2 <> 0) Then
                b1.Image = p2.Image
                pr1 = 2
            Else
                b1.Image = p1.Image
                pr1 = 1
            End If
            vys1()
            vys2()
        End If
    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        If (pocetH Mod 2 <> 0) Then
            i += 1
            If (i Mod 2 <> 0) Then
                b2.Image = p1.Image
                pr2 = 1
            Else
                b2.Image = p2.Image
                pr2 = 2
            End If
            vys1()
            vys2()
        End If

        If (pocetH Mod 2 = 0) Then
            i += 1
            If (i Mod 2 <> 0) Then
                b2.Image = p2.Image
                pr2 = 2
            Else
                b2.Image = p1.Image
                pr2 = 1
            End If
            vys1()
            vys2()
        End If

    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        If (pocetH Mod 2 <> 0) Then
            i += 1
            If (i Mod 2 <> 0) Then
                b3.Image = p1.Image
                pr3 = 1
            Else
                b3.Image = p2.Image
                pr3 = 2
            End If
            vys1()
            vys2()
        End If
        If (pocetH Mod 2 = 0) Then
            i += 1
            If (i Mod 2 <> 0) Then
                b3.Image = p2.Image
                pr3 = 2
            Else
                b3.Image = p1.Image
                pr3 = 1
            End If
            vys1()
            vys2()
        End If
    End Sub

    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click
        If (pocetH Mod 2 <> 0) Then
            i += 1
            If (i Mod 2 <> 0) Then
                b4.Image = p1.Image
                pr4 = 1
            Else
                b4.Image = p2.Image
                pr4 = 2
            End If
            vys1()
            vys2()
        End If

        If (pocetH Mod 2 = 0) Then
            i += 1
            If (i Mod 2 <> 0) Then
                b4.Image = p2.Image
                pr4 = 2
            Else
                b4.Image = p1.Image
                pr4 = 1
            End If
            vys1()
            vys2()
        End If
    End Sub

    Private Sub b5_Click(sender As Object, e As EventArgs) Handles b5.Click
        If (pocetH Mod 2 <> 0) Then
            i += 1
            If (i Mod 2 <> 0) Then
                b5.Image = p1.Image
                pr5 = 1
            Else
                b5.Image = p2.Image
                pr5 = 2
            End If
            vys1()
            vys2()
        End If

        If (pocetH Mod 2 = 0) Then
            i += 1
            If (i Mod 2 <> 0) Then
                b5.Image = p2.Image
                pr5 = 2
            Else
                b5.Image = p1.Image
                pr5 = 1
            End If
            vys1()
            vys2()
        End If
    End Sub

    Private Sub b6_Click(sender As Object, e As EventArgs) Handles b6.Click
        If (pocetH Mod 2 <> 0) Then
            i += 1
            If (i Mod 2 <> 0) Then
                b6.Image = p1.Image
                pr6 = 1
            Else
                b6.Image = p2.Image
                pr6 = 2
            End If
            vys1()
            vys2()
        End If

        If (pocetH Mod 2 = 0) Then
            i += 1
            If (i Mod 2 <> 0) Then
                b6.Image = p2.Image
                pr6 = 2
            Else
                b6.Image = p1.Image
                pr6 = 1
            End If
            vys1()
            vys2()
        End If
    End Sub

    Private Sub b7_Click(sender As Object, e As EventArgs) Handles b7.Click
        If (pocetH Mod 2 <> 0) Then
            i += 1
            If (i Mod 2 <> 0) Then
                b7.Image = p1.Image
                pr7 = 1
            Else
                b7.Image = p2.Image
                pr7 = 2
            End If
            vys1()
            vys2()
        End If

        If (pocetH Mod 2 = 0) Then
            i += 1
            If (i Mod 2 <> 0) Then
                b7.Image = p2.Image
                pr7 = 2
            Else
                b7.Image = p1.Image
                pr7 = 1
            End If
            vys1()
            vys2()
        End If
    End Sub

    Private Sub b8_Click(sender As Object, e As EventArgs) Handles b8.Click
        If (pocetH Mod 2 <> 0) Then
            i += 1
            If (i Mod 2 <> 0) Then
                b8.Image = p1.Image
                pr8 = 1
            Else
                b8.Image = p2.Image
                pr8 = 2
            End If
            vys1()
            vys2()
        End If

        If (pocetH Mod 2 = 0) Then
            i += 1
            If (i Mod 2 <> 0) Then
                b8.Image = p2.Image
                pr8 = 2
            Else
                b8.Image = p1.Image
                pr8 = 1
            End If
            vys1()
            vys2()
        End If
    End Sub

    Private Sub b9_Click(sender As Object, e As EventArgs) Handles b9.Click
        If (pocetH Mod 2 <> 0) Then
            i += 1
            If (i Mod 2 <> 0) Then
                b9.Image = p1.Image
                pr9 = 1
            Else
                b9.Image = p2.Image
                pr9 = 2
            End If
            vys1()
            vys2()
        End If

        If (pocetH Mod 2 = 0) Then
            i += 1
            If (i Mod 2 <> 0) Then
                b9.Image = p2.Image
                pr9 = 2
            Else
                b9.Image = p1.Image
                pr9 = 1
            End If
            vys1()
            vys2()
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btDalsi_Click(sender As Object, e As EventArgs) Handles btDalsi.Click
        novy()
    End Sub
End Class