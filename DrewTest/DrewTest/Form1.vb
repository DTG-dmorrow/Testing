Public Class FlippinVintage

    Private entry As Double
    Private results As String

    Private Kelly As Double = 0
    Private includeKelly As Boolean = True
    Private Kristi As Double = 0
    Private includeKristi As Boolean = True
    Private Julie As Double = 0
    Private includeJulie As Boolean = True
    Private Other As Double = 0
    Private includeOther As Boolean = False
    Private amountToSplit As Double

    Private numberChecked As Integer = 3

    Private Sub finalResults(ByVal sender As Object, ByVal e As System.EventArgs) Handles OutputResults.Click
        If SplitButton2.Checked Then
            results = Output.Text
            results = vbCrLf & Output.Text
            results = "Total: $" & (Kelly + Kristi + Julie + Other) & vbCrLf & results
            If includeOther Then
                results = "Other: $" & Other & vbCrLf & results
            End If
            If includeJulie Then
                results = "Julie: $" & Julie & vbCrLf & results
            End If
            If includeKristi Then
                results = "Kristi: $" & Kristi & vbCrLf & results
            End If
            If includeKelly Then
                results = "Kelly: $" & Kelly & vbCrLf & results
            End If
            Output.Text = results
            Me.ActiveControl = Input
        Else
            amountToSplit = SplitAmount.Text / numberChecked
            results = vbCrLf & Output.Text
            results = "Total: $" & (Kelly + Kristi + Julie + Other) & vbCrLf & results
            If includeOther Then
                results = "Other: $" & (Other - amountToSplit) & vbCrLf & results
            End If
            If includeJulie Then
                results = "Julie: $" & (Julie - amountToSplit) & vbCrLf & results
            End If
            If includeKristi Then
                results = "Kristi: $" & (Kristi - amountToSplit) & vbCrLf & results
            End If
            If includeKelly Then
                results = "Kelly: $" & (Kelly - amountToSplit) & vbCrLf & results
            End If
            Output.Text = results
            Me.ActiveControl = Input
        End If
    End Sub

    Private Sub entryFunction()
        Try
            entry = Input.Text
            Dim entryString As String = CType(entry, String)
            Dim lastTwoDigits As String = ""
            results = Output.Text

            If entryString.Contains(".") Then
                If (entryString.Length() < 3) Then
                    Throw New Exception
                Else
                    lastTwoDigits = entryString.Substring(entryString.Length() - 2)
                End If
            Else
                Throw New Exception
            End If

            Select Case lastTwoDigits
                Case "25"
                    Kristi += entry
                Case "33"
                    Kelly += entry
                Case ".5"
                    Kelly += entry
                Case "75"
                    Julie += entry
                Case "99"
                    Other += entry
                Case Else
                    Output.Text = entry & " is an invalid entry!" & vbCrLf & vbCrLf & results
                    Input.Text = ""
                    Throw New Exception
            End Select

            Input.Text = ""
            Output.Text = entry & vbCrLf & results

        Catch ex As Exception
        End Try
        Me.ActiveControl = Input
    End Sub

    Private Sub processEntry(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubmitInput.Click
        entryFunction()
    End Sub

    Private Sub ExitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub Input_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Input.KeyPress
        Dim myKey As Char = e.KeyChar
        If Char.IsControl(myKey) Then
            entryFunction()
        End If
    End Sub

    Private Sub ClearButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        Input.Text = ""
        Output.Text = ""
        Kelly = 0
        Kristi = 0
        Julie = 0
        Other = 0
        Me.ActiveControl = Input
    End Sub

    Private Sub Form1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.ActiveControl = Input
    End Sub

    Private Sub SplitButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SplitButton1.Click
        SplitAmount.Text = 1
    End Sub

    Private Sub SplitButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SplitButton2.Click
        SplitAmount.Text = ""
    End Sub

    Private Sub KellyCheckBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles KellyCheckBox.Click
        If includeKelly Then
            numberChecked = numberChecked - 1
            includeKelly = False
            KellyCheckBox.Checked = False
        Else
            numberChecked = numberChecked + 1
            includeKelly = True
            KellyCheckBox.Checked = True
        End If
    End Sub

    Private Sub KristiCheckBox_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles KristiCheckBox.Click
        If includeKristi Then
            numberChecked = numberChecked - 1
            includeKristi = False
            KristiCheckBox.Checked = False
        Else
            numberChecked = numberChecked + 1
            includeKristi = True
            KristiCheckBox.Checked = True
        End If
    End Sub

    Private Sub JulieCheckBox_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles JulieCheckBox.Click
        If includeJulie Then
            numberChecked = numberChecked - 1
            includeJulie = False
            JulieCheckBox.Checked = False
        Else
            numberChecked = numberChecked + 1
            includeJulie = True
            JulieCheckBox.Checked = True
        End If
    End Sub

    Private Sub OtherCheckBox_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles OtherCheckBox.Click
        If includeOther Then
            numberChecked = numberChecked - 1
            includeOther = False
            OtherCheckBox.Checked = False
        Else
            numberChecked = numberChecked + 1
            includeOther = True
            OtherCheckBox.Checked = True
        End If
    End Sub
End Class
