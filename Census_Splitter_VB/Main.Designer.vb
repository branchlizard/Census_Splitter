<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.InputFolderDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.InputFolderButton = New System.Windows.Forms.Button()
        Me.InputFolderTextbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OutputFolderTextbox = New System.Windows.Forms.TextBox()
        Me.OutputFolderButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RunButton = New System.Windows.Forms.Button()
        Me.OutputFolderDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'InputFolderDialog
        '
        '
        'InputFolderButton
        '
        Me.InputFolderButton.AccessibleName = ""
        Me.InputFolderButton.Location = New System.Drawing.Point(197, 70)
        Me.InputFolderButton.Name = "InputFolderButton"
        Me.InputFolderButton.Size = New System.Drawing.Size(101, 23)
        Me.InputFolderButton.TabIndex = 0
        Me.InputFolderButton.Text = "Browse"
        Me.InputFolderButton.UseVisualStyleBackColor = True
        '
        'InputFolderTextbox
        '
        Me.InputFolderTextbox.Location = New System.Drawing.Point(12, 71)
        Me.InputFolderTextbox.Name = "InputFolderTextbox"
        Me.InputFolderTextbox.Size = New System.Drawing.Size(178, 23)
        Me.InputFolderTextbox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Browse to Input Data Folder"
        '
        'OutputFolderTextbox
        '
        Me.OutputFolderTextbox.Location = New System.Drawing.Point(12, 124)
        Me.OutputFolderTextbox.Name = "OutputFolderTextbox"
        Me.OutputFolderTextbox.Size = New System.Drawing.Size(177, 23)
        Me.OutputFolderTextbox.TabIndex = 3
        '
        'OutputFolderButton
        '
        Me.OutputFolderButton.Location = New System.Drawing.Point(197, 121)
        Me.OutputFolderButton.Name = "OutputFolderButton"
        Me.OutputFolderButton.Size = New System.Drawing.Size(102, 27)
        Me.OutputFolderButton.TabIndex = 4
        Me.OutputFolderButton.Text = "Browse"
        Me.OutputFolderButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Browse to Desired Output Location"
        '
        'RunButton
        '
        Me.RunButton.Location = New System.Drawing.Point(107, 176)
        Me.RunButton.Name = "RunButton"
        Me.RunButton.Size = New System.Drawing.Size(106, 34)
        Me.RunButton.TabIndex = 6
        Me.RunButton.Text = "Run"
        Me.RunButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(107, 216)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(106, 30)
        Me.CloseButton.TabIndex = 7
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 318)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.RunButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.OutputFolderButton)
        Me.Controls.Add(Me.OutputFolderTextbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.InputFolderTextbox)
        Me.Controls.Add(Me.InputFolderButton)
        Me.Name = "Main"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InputFolderDialog As FolderBrowserDialog
    Friend WithEvents InputFolderButton As Button
    Friend WithEvents InputFolderTextbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OutputFolderTextbox As TextBox
    Friend WithEvents OutputFolderButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents RunButton As Button
    Friend WithEvents OutputFolderDialog As FolderBrowserDialog
    Friend WithEvents CloseButton As Button
End Class
