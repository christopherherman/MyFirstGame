<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSnake
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
        Me.components = New System.ComponentModel.Container()
        Me.tmrGame = New System.Windows.Forms.Timer(Me.components)
        Me.picGame = New System.Windows.Forms.PictureBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        CType(Me.picGame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrGame
        '
        '
        'picGame
        '
        Me.picGame.BackColor = System.Drawing.Color.Cyan
        Me.picGame.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picGame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picGame.Location = New System.Drawing.Point(0, 0)
        Me.picGame.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picGame.Name = "picGame"
        Me.picGame.Size = New System.Drawing.Size(461, 365)
        Me.picGame.TabIndex = 0
        Me.picGame.TabStop = False
        '
        'lblMessage
        '
        Me.lblMessage.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMessage.BackColor = System.Drawing.Color.Cyan
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(-3, 134)
        Me.lblMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(464, 86)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.Text = "Press Enter to Start"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSnake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(461, 365)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.picGame)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmSnake"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Snake Game"
        CType(Me.picGame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tmrGame As Timer
    Friend WithEvents picGame As PictureBox
    Friend WithEvents lblMessage As Label
End Class
