<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMilliennium
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnCounrties = New System.Windows.Forms.TextBox()
        Me.txtDisplyUniv = New System.Windows.Forms.TextBox()
        Me.txtnYears = New System.Windows.Forms.TextBox()
        Me.txtDisplyData = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.BtnDisplayList = New System.Windows.Forms.Button()
        Me.BtnDisplay = New System.Windows.Forms.Button()
        Me.BtnSaveInfo = New System.Windows.Forms.Button()
        Me.BtnSummary = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(214, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Number of Countries"
        '
        'txtnCounrties
        '
        Me.txtnCounrties.Location = New System.Drawing.Point(379, 30)
        Me.txtnCounrties.Name = "txtnCounrties"
        Me.txtnCounrties.Size = New System.Drawing.Size(31, 20)
        Me.txtnCounrties.TabIndex = 27
        '
        'txtDisplyUniv
        '
        Me.txtDisplyUniv.Location = New System.Drawing.Point(379, 172)
        Me.txtDisplyUniv.Multiline = True
        Me.txtDisplyUniv.Name = "txtDisplyUniv"
        Me.txtDisplyUniv.ReadOnly = True
        Me.txtDisplyUniv.Size = New System.Drawing.Size(248, 234)
        Me.txtDisplyUniv.TabIndex = 26
        '
        'txtnYears
        '
        Me.txtnYears.Location = New System.Drawing.Point(379, 4)
        Me.txtnYears.Name = "txtnYears"
        Me.txtnYears.Size = New System.Drawing.Size(31, 20)
        Me.txtnYears.TabIndex = 25
        '
        'txtDisplyData
        '
        Me.txtDisplyData.Location = New System.Drawing.Point(30, 172)
        Me.txtDisplyData.Multiline = True
        Me.txtDisplyData.Name = "txtDisplyData"
        Me.txtDisplyData.ReadOnly = True
        Me.txtDisplyData.Size = New System.Drawing.Size(268, 234)
        Me.txtDisplyData.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(214, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Number of years"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(207, 67)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(203, 31)
        Me.btnStart.TabIndex = 22
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'BtnDisplayList
        '
        Me.BtnDisplayList.Location = New System.Drawing.Point(30, 104)
        Me.BtnDisplayList.Name = "BtnDisplayList"
        Me.BtnDisplayList.Size = New System.Drawing.Size(142, 34)
        Me.BtnDisplayList.TabIndex = 21
        Me.BtnDisplayList.Text = "Display Eligible Countries List"
        Me.BtnDisplayList.UseVisualStyleBackColor = True
        '
        'BtnDisplay
        '
        Me.BtnDisplay.Location = New System.Drawing.Point(207, 104)
        Me.BtnDisplay.Name = "BtnDisplay"
        Me.BtnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.BtnDisplay.TabIndex = 20
        Me.BtnDisplay.Text = "Display Info"
        Me.BtnDisplay.UseVisualStyleBackColor = True
        '
        'BtnSaveInfo
        '
        Me.BtnSaveInfo.Location = New System.Drawing.Point(379, 104)
        Me.BtnSaveInfo.Name = "BtnSaveInfo"
        Me.BtnSaveInfo.Size = New System.Drawing.Size(75, 23)
        Me.BtnSaveInfo.TabIndex = 19
        Me.BtnSaveInfo.Text = "Save Data"
        Me.BtnSaveInfo.UseVisualStyleBackColor = True
        '
        'BtnSummary
        '
        Me.BtnSummary.Location = New System.Drawing.Point(552, 104)
        Me.BtnSummary.Name = "BtnSummary"
        Me.BtnSummary.Size = New System.Drawing.Size(75, 23)
        Me.BtnSummary.TabIndex = 18
        Me.BtnSummary.Text = "Summary"
        Me.BtnSummary.UseVisualStyleBackColor = True
        '
        'frmMilliennium
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 410)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnCounrties)
        Me.Controls.Add(Me.txtDisplyUniv)
        Me.Controls.Add(Me.txtnYears)
        Me.Controls.Add(Me.txtDisplyData)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.BtnDisplayList)
        Me.Controls.Add(Me.BtnDisplay)
        Me.Controls.Add(Me.BtnSaveInfo)
        Me.Controls.Add(Me.BtnSummary)
        Me.Name = "frmMilliennium"
        Me.Text = "Milliennium Goals"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents txtnCounrties As TextBox
    Friend WithEvents txtDisplyUniv As TextBox
    Friend WithEvents txtnYears As TextBox
    Friend WithEvents txtDisplyData As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents BtnDisplayList As Button
    Friend WithEvents BtnDisplay As Button
    Friend WithEvents BtnSaveInfo As Button
    Friend WithEvents BtnSummary As Button
End Class
