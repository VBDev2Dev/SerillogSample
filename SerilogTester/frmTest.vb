Imports Serilog

Public Class frmTest
	 Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
		  Log.Logger.Information("You clicked me.")
	 End Sub
End Class
