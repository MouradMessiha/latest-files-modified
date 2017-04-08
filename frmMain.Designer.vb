<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
      Me.btnStart = New System.Windows.Forms.Button
      Me.lstFiles = New System.Windows.Forms.ListBox
      Me.lblCurrentFile = New System.Windows.Forms.Label
      Me.SuspendLayout()
      '
      'btnStart
      '
      Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnStart.Location = New System.Drawing.Point(457, 13)
      Me.btnStart.Name = "btnStart"
      Me.btnStart.Size = New System.Drawing.Size(204, 40)
      Me.btnStart.TabIndex = 0
      Me.btnStart.Text = "Start"
      Me.btnStart.UseVisualStyleBackColor = True
      '
      'lstFiles
      '
      Me.lstFiles.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lstFiles.FormattingEnabled = True
      Me.lstFiles.ItemHeight = 14
      Me.lstFiles.Location = New System.Drawing.Point(12, 83)
      Me.lstFiles.Name = "lstFiles"
      Me.lstFiles.Size = New System.Drawing.Size(1094, 704)
      Me.lstFiles.TabIndex = 1
      '
      'lblCurrentFile
      '
      Me.lblCurrentFile.AutoSize = True
      Me.lblCurrentFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCurrentFile.Location = New System.Drawing.Point(9, 57)
      Me.lblCurrentFile.Name = "lblCurrentFile"
      Me.lblCurrentFile.Size = New System.Drawing.Size(0, 16)
      Me.lblCurrentFile.TabIndex = 2
      '
      'frmMain
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(1118, 803)
      Me.Controls.Add(Me.lblCurrentFile)
      Me.Controls.Add(Me.lstFiles)
      Me.Controls.Add(Me.btnStart)
      Me.Name = "frmMain"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Latest Files Modified"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents btnStart As System.Windows.Forms.Button
   Friend WithEvents lstFiles As System.Windows.Forms.ListBox
   Friend WithEvents lblCurrentFile As System.Windows.Forms.Label

End Class
