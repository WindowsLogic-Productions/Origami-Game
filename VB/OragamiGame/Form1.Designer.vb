<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.OrigamiButton = New System.Windows.Forms.Button()
        Me.OrigamiButton2 = New System.Windows.Forms.Button()
        Me.OrigamiButton3 = New System.Windows.Forms.Button()
        Me.OrigamiButton4 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OrigamiButton
        '
        Me.OrigamiButton.Location = New System.Drawing.Point(12, 12)
        Me.OrigamiButton.Name = "OrigamiButton"
        Me.OrigamiButton.Size = New System.Drawing.Size(100, 100)
        Me.OrigamiButton.TabIndex = 0
        Me.OrigamiButton.Text = "1"
        Me.OrigamiButton.UseVisualStyleBackColor = True
        '
        'OrigamiButton2
        '
        Me.OrigamiButton2.Location = New System.Drawing.Point(118, 12)
        Me.OrigamiButton2.Name = "OrigamiButton2"
        Me.OrigamiButton2.Size = New System.Drawing.Size(100, 100)
        Me.OrigamiButton2.TabIndex = 1
        Me.OrigamiButton2.Text = "4"
        Me.OrigamiButton2.UseVisualStyleBackColor = True
        '
        'OrigamiButton3
        '
        Me.OrigamiButton3.Location = New System.Drawing.Point(12, 118)
        Me.OrigamiButton3.Name = "OrigamiButton3"
        Me.OrigamiButton3.Size = New System.Drawing.Size(100, 100)
        Me.OrigamiButton3.TabIndex = 2
        Me.OrigamiButton3.Text = "2"
        Me.OrigamiButton3.UseVisualStyleBackColor = True
        '
        'OrigamiButton4
        '
        Me.OrigamiButton4.Location = New System.Drawing.Point(118, 118)
        Me.OrigamiButton4.Name = "OrigamiButton4"
        Me.OrigamiButton4.Size = New System.Drawing.Size(100, 100)
        Me.OrigamiButton4.TabIndex = 3
        Me.OrigamiButton4.Text = "3"
        Me.OrigamiButton4.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(183, 221)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(35, 13)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "About"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(142, 221)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(35, 13)
        Me.LinkLabel2.TabIndex = 5
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Reset"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 255)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.OrigamiButton4)
        Me.Controls.Add(Me.OrigamiButton3)
        Me.Controls.Add(Me.OrigamiButton2)
        Me.Controls.Add(Me.OrigamiButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Origami Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OrigamiButton As Button
    Friend WithEvents OrigamiButton2 As Button
    Friend WithEvents OrigamiButton3 As Button
    Friend WithEvents OrigamiButton4 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label1 As Label
End Class
