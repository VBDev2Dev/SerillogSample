Imports Microsoft.VisualBasic.ApplicationServices
Imports Serilog

Namespace My
	 ' The following events are available for MyApplication:
	 ' Startup: Raised when the application starts, before the startup form is created.
	 ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
	 ' UnhandledException: Raised if the application encounters an unhandled exception.
	 ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
	 ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
	 Partial Friend Class MyApplication
		  Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
				Serilog.Log.Logger = New LoggerConfiguration().
					 MinimumLevel.Debug().
					 Enrich.FromLogContext.
					 Enrich.WithCaller().
					 WriteTo.RollingFile(IO.Path.Combine(My.Application.Info.DirectoryPath, "log-{Date}.txt"),
												outputTemplate:="{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level}] ({Caller}) {Message}{NewLine}{Exception}").
					 CreateLogger()
				Serilog.Log.Logger.Information("App start.")

		  End Sub
	 End Class
End Namespace
