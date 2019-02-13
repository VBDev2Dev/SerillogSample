<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest
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
		  Me.btnTest = New System.Windows.Forms.Button()
		  Me.SuspendLayout()
		  '
		  'btnTest
		  '
		  Me.btnTest.Location = New System.Drawing.Point(206, 103)
		  Me.btnTest.Name = "btnTest"
		  Me.btnTest.Size = New System.Drawing.Size(75, 23)
		  Me.btnTest.TabIndex = 0
		  Me.btnTest.Text = "Click me"
		  Me.btnTest.UseVisualStyleBackColor = True
		  '
		  'Form1
		  '
		  Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		  Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		  Me.ClientSize = New System.Drawing.Size(487, 229)
		  Me.Controls.Add(Me.btnTest)
		  Me.Name = "Form1"
		  Me.Text = "Form1"
		  Me.ResumeLayout(False)

	 End Sub

	 Friend WithEvents btnTest As Button
End Class
