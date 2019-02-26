Imports System.Runtime.CompilerServices
Imports Serilog
Imports Serilog.Configuration
Imports Serilog.Core
Imports Serilog.Events

Class CallerEnricher
	 Implements ILogEventEnricher
	 'https://github.com/serilog/serilog/issues/1084
	 Public Sub Enrich(ByVal logEvent As LogEvent, ByVal propertyFactory As ILogEventPropertyFactory) Implements ILogEventEnricher.Enrich
		  Dim skip = 3

		  While True
				Dim stack = New StackFrame(skip, True)

				If Not stack.HasMethod() Then
					 logEvent.AddPropertyIfAbsent(New LogEventProperty("Caller", New ScalarValue("<unknown method>")))
					 Return
				End If

				Dim method = stack.GetMethod()

				If method.DeclaringType.Assembly <> GetType(Log).Assembly Then
					 Dim caller = $"{method.DeclaringType.FullName}.{method.Name}({String.Join(", ", method.GetParameters().[Select](Function(pi) pi.ParameterType.FullName))}) File:{stack.GetFileName} Line: {stack.GetFileLineNumber}"
					 logEvent.AddPropertyIfAbsent(New LogEventProperty("Caller", New ScalarValue(caller)))
				End If

				skip += 1
		  End While
	 End Sub


End Class

Module LoggerCallerEnrichmentConfiguration
	 <Extension()>
	 Function WithCaller(ByVal enrichmentConfiguration As LoggerEnrichmentConfiguration) As LoggerConfiguration
		  Return enrichmentConfiguration.[With](Of CallerEnricher)()
	 End Function
End Module