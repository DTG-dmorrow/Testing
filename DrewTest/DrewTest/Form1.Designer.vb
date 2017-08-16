<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlippinVintage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OutputResults = New System.Windows.Forms.Button()
        Me.Input = New System.Windows.Forms.TextBox()
        Me.Output = New System.Windows.Forms.TextBox()
        Me.SubmitInput = New System.Windows.Forms.Button()
        Me.Process = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SplitButton1 = New System.Windows.Forms.RadioButton()
        Me.SplitButton2 = New System.Windows.Forms.RadioButton()
        Me.SplitAmount = New System.Windows.Forms.TextBox()
        Me.SplitConfirmation = New System.Windows.Forms.Label()
        Me.SplitAmountLabel = New System.Windows.Forms.Label()
        Me.EntryLabel = New System.Windows.Forms.Label()
        Me.PeopleInvolved = New System.Windows.Forms.Label()
        Me.KellyCheckBox = New System.Windows.Forms.CheckBox()
        Me.KristiCheckBox = New System.Windows.Forms.CheckBox()
        Me.JulieCheckBox = New System.Windows.Forms.CheckBox()
        Me.OtherCheckBox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'OutputResults
        '
        Me.OutputResults.BackColor = System.Drawing.Color.Turquoise
        Me.OutputResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.OutputResults.ForeColor = System.Drawing.Color.Yellow
        Me.OutputResults.Location = New System.Drawing.Point(405, 347)
        Me.OutputResults.Name = "OutputResults"
        Me.OutputResults.Size = New System.Drawing.Size(93, 34)
        Me.OutputResults.TabIndex = 2
        Me.OutputResults.Text = "Get Results"
        Me.OutputResults.UseVisualStyleBackColor = False
        '
        'Input
        '
        Me.Input.BackColor = System.Drawing.Color.Turquoise
        Me.Input.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Input.ForeColor = System.Drawing.Color.Yellow
        Me.Input.Location = New System.Drawing.Point(60, 52)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(189, 23)
        Me.Input.TabIndex = 3
        Me.Input.TabStop = False
        Me.Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Output
        '
        Me.Output.BackColor = System.Drawing.Color.Turquoise
        Me.Output.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Output.ForeColor = System.Drawing.Color.Yellow
        Me.Output.Location = New System.Drawing.Point(59, 89)
        Me.Output.Multiline = True
        Me.Output.Name = "Output"
        Me.Output.ReadOnly = True
        Me.Output.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Output.Size = New System.Drawing.Size(320, 280)
        Me.Output.TabIndex = 4
        '
        'SubmitInput
        '
        Me.SubmitInput.BackColor = System.Drawing.Color.Turquoise
        Me.SubmitInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SubmitInput.ForeColor = System.Drawing.Color.Yellow
        Me.SubmitInput.Location = New System.Drawing.Point(275, 52)
        Me.SubmitInput.Name = "SubmitInput"
        Me.SubmitInput.Size = New System.Drawing.Size(104, 23)
        Me.SubmitInput.TabIndex = 5
        Me.SubmitInput.Text = "Submit Entry"
        Me.SubmitInput.UseVisualStyleBackColor = False
        '
        'Process
        '
        Me.Process.BackColor = System.Drawing.Color.MistyRose
        Me.Process.ForeColor = System.Drawing.Color.Red
        Me.Process.Location = New System.Drawing.Point(296, 57)
        Me.Process.Name = "Process"
        Me.Process.Size = New System.Drawing.Size(68, 20)
        Me.Process.TabIndex = 5
        Me.Process.Text = "Submit"
        Me.Process.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Turquoise
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ExitButton.ForeColor = System.Drawing.Color.Yellow
        Me.ExitButton.Location = New System.Drawing.Point(233, 385)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(146, 34)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.Turquoise
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ClearButton.ForeColor = System.Drawing.Color.Yellow
        Me.ClearButton.Location = New System.Drawing.Point(60, 385)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(154, 34)
        Me.ClearButton.TabIndex = 7
        Me.ClearButton.Text = "Reset"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'SplitButton1
        '
        Me.SplitButton1.AutoSize = True
        Me.SplitButton1.BackColor = System.Drawing.Color.LightPink
        Me.SplitButton1.FlatAppearance.BorderColor = System.Drawing.Color.Pink
        Me.SplitButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Turquoise
        Me.SplitButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise
        Me.SplitButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SplitButton1.ForeColor = System.Drawing.Color.Yellow
        Me.SplitButton1.Location = New System.Drawing.Point(405, 217)
        Me.SplitButton1.Name = "SplitButton1"
        Me.SplitButton1.Size = New System.Drawing.Size(50, 21)
        Me.SplitButton1.TabIndex = 8
        Me.SplitButton1.Text = "Yes"
        Me.SplitButton1.UseVisualStyleBackColor = False
        '
        'SplitButton2
        '
        Me.SplitButton2.AutoSize = True
        Me.SplitButton2.BackColor = System.Drawing.Color.LightPink
        Me.SplitButton2.Checked = True
        Me.SplitButton2.FlatAppearance.BorderColor = System.Drawing.Color.Pink
        Me.SplitButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Turquoise
        Me.SplitButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise
        Me.SplitButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SplitButton2.ForeColor = System.Drawing.Color.Yellow
        Me.SplitButton2.Location = New System.Drawing.Point(405, 240)
        Me.SplitButton2.Name = "SplitButton2"
        Me.SplitButton2.Size = New System.Drawing.Size(44, 21)
        Me.SplitButton2.TabIndex = 9
        Me.SplitButton2.TabStop = True
        Me.SplitButton2.Text = "No"
        Me.SplitButton2.UseVisualStyleBackColor = False
        '
        'SplitAmount
        '
        Me.SplitAmount.BackColor = System.Drawing.Color.Turquoise
        Me.SplitAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SplitAmount.ForeColor = System.Drawing.Color.Yellow
        Me.SplitAmount.Location = New System.Drawing.Point(405, 306)
        Me.SplitAmount.Name = "SplitAmount"
        Me.SplitAmount.Size = New System.Drawing.Size(77, 23)
        Me.SplitAmount.TabIndex = 10
        Me.SplitAmount.TabStop = False
        Me.SplitAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SplitConfirmation
        '
        Me.SplitConfirmation.AutoSize = True
        Me.SplitConfirmation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SplitConfirmation.ForeColor = System.Drawing.Color.Yellow
        Me.SplitConfirmation.Location = New System.Drawing.Point(402, 178)
        Me.SplitConfirmation.Name = "SplitConfirmation"
        Me.SplitConfirmation.Size = New System.Drawing.Size(104, 34)
        Me.SplitConfirmation.TabIndex = 11
        Me.SplitConfirmation.Text = "Would you like " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to split a cost?"
        '
        'SplitAmountLabel
        '
        Me.SplitAmountLabel.AutoSize = True
        Me.SplitAmountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SplitAmountLabel.ForeColor = System.Drawing.Color.Yellow
        Me.SplitAmountLabel.Location = New System.Drawing.Point(402, 290)
        Me.SplitAmountLabel.Name = "SplitAmountLabel"
        Me.SplitAmountLabel.Size = New System.Drawing.Size(99, 17)
        Me.SplitAmountLabel.TabIndex = 12
        Me.SplitAmountLabel.Text = "By how much?"
        '
        'EntryLabel
        '
        Me.EntryLabel.AutoSize = True
        Me.EntryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.EntryLabel.ForeColor = System.Drawing.Color.Yellow
        Me.EntryLabel.Location = New System.Drawing.Point(57, 36)
        Me.EntryLabel.Name = "EntryLabel"
        Me.EntryLabel.Size = New System.Drawing.Size(117, 17)
        Me.EntryLabel.TabIndex = 13
        Me.EntryLabel.Text = "Enter an amount:"
        '
        'PeopleInvolved
        '
        Me.PeopleInvolved.AutoSize = True
        Me.PeopleInvolved.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PeopleInvolved.ForeColor = System.Drawing.Color.Yellow
        Me.PeopleInvolved.Location = New System.Drawing.Point(402, 52)
        Me.PeopleInvolved.Name = "PeopleInvolved"
        Me.PeopleInvolved.Size = New System.Drawing.Size(112, 17)
        Me.PeopleInvolved.TabIndex = 14
        Me.PeopleInvolved.Text = "Who's included?"
        '
        'KellyCheckBox
        '
        Me.KellyCheckBox.AutoSize = True
        Me.KellyCheckBox.BackColor = System.Drawing.Color.LightPink
        Me.KellyCheckBox.Checked = True
        Me.KellyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.KellyCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Pink
        Me.KellyCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Turquoise
        Me.KellyCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise
        Me.KellyCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.KellyCheckBox.ForeColor = System.Drawing.Color.Yellow
        Me.KellyCheckBox.Location = New System.Drawing.Point(405, 72)
        Me.KellyCheckBox.Name = "KellyCheckBox"
        Me.KellyCheckBox.Size = New System.Drawing.Size(57, 21)
        Me.KellyCheckBox.TabIndex = 15
        Me.KellyCheckBox.Text = "Kelly"
        Me.KellyCheckBox.UseVisualStyleBackColor = False
        '
        'KristiCheckBox
        '
        Me.KristiCheckBox.AutoSize = True
        Me.KristiCheckBox.BackColor = System.Drawing.Color.LightPink
        Me.KristiCheckBox.Checked = True
        Me.KristiCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.KristiCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Pink
        Me.KristiCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Turquoise
        Me.KristiCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise
        Me.KristiCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.KristiCheckBox.ForeColor = System.Drawing.Color.Yellow
        Me.KristiCheckBox.Location = New System.Drawing.Point(405, 95)
        Me.KristiCheckBox.Name = "KristiCheckBox"
        Me.KristiCheckBox.Size = New System.Drawing.Size(58, 21)
        Me.KristiCheckBox.TabIndex = 16
        Me.KristiCheckBox.Text = "Kristi"
        Me.KristiCheckBox.UseVisualStyleBackColor = False
        '
        'JulieCheckBox
        '
        Me.JulieCheckBox.AutoSize = True
        Me.JulieCheckBox.BackColor = System.Drawing.Color.LightPink
        Me.JulieCheckBox.Checked = True
        Me.JulieCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.JulieCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Pink
        Me.JulieCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Turquoise
        Me.JulieCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise
        Me.JulieCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.JulieCheckBox.ForeColor = System.Drawing.Color.Yellow
        Me.JulieCheckBox.Location = New System.Drawing.Point(405, 118)
        Me.JulieCheckBox.Name = "JulieCheckBox"
        Me.JulieCheckBox.Size = New System.Drawing.Size(56, 21)
        Me.JulieCheckBox.TabIndex = 17
        Me.JulieCheckBox.Text = "Julie"
        Me.JulieCheckBox.UseVisualStyleBackColor = False
        '
        'OtherCheckBox
        '
        Me.OtherCheckBox.AutoSize = True
        Me.OtherCheckBox.BackColor = System.Drawing.Color.LightPink
        Me.OtherCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Pink
        Me.OtherCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Turquoise
        Me.OtherCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise
        Me.OtherCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.OtherCheckBox.ForeColor = System.Drawing.Color.Yellow
        Me.OtherCheckBox.Location = New System.Drawing.Point(405, 141)
        Me.OtherCheckBox.Name = "OtherCheckBox"
        Me.OtherCheckBox.Size = New System.Drawing.Size(63, 21)
        Me.OtherCheckBox.TabIndex = 18
        Me.OtherCheckBox.Text = "Other"
        Me.OtherCheckBox.UseVisualStyleBackColor = False
        '
        'FlippinVintage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(520, 442)
        Me.Controls.Add(Me.OtherCheckBox)
        Me.Controls.Add(Me.JulieCheckBox)
        Me.Controls.Add(Me.KristiCheckBox)
        Me.Controls.Add(Me.KellyCheckBox)
        Me.Controls.Add(Me.PeopleInvolved)
        Me.Controls.Add(Me.EntryLabel)
        Me.Controls.Add(Me.SplitAmountLabel)
        Me.Controls.Add(Me.SplitConfirmation)
        Me.Controls.Add(Me.SplitAmount)
        Me.Controls.Add(Me.SplitButton2)
        Me.Controls.Add(Me.SplitButton1)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SubmitInput)
        Me.Controls.Add(Me.Output)
        Me.Controls.Add(Me.Input)
        Me.Controls.Add(Me.OutputResults)
        Me.Name = "FlippinVintage"
        Me.Text = "Flippin Vintage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OutputResults As System.Windows.Forms.Button
    Friend WithEvents Input As System.Windows.Forms.TextBox
    Friend WithEvents Output As System.Windows.Forms.TextBox
    Friend WithEvents SubmitInput As System.Windows.Forms.Button
    Friend WithEvents Process As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents SplitButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents SplitButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents SplitAmount As System.Windows.Forms.TextBox
    Friend WithEvents SplitConfirmation As System.Windows.Forms.Label
    Friend WithEvents SplitAmountLabel As System.Windows.Forms.Label
    Friend WithEvents EntryLabel As System.Windows.Forms.Label
    Friend WithEvents PeopleInvolved As System.Windows.Forms.Label
    Friend WithEvents KellyCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents KristiCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents JulieCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents OtherCheckBox As System.Windows.Forms.CheckBox

End Class
