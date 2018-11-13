using Serilog;
using Serilog.Configuration;
using Serilog.Core;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Website_Monitoring.Library {
    public static class LogManager {
        private static string _templateWithoutCaller = "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level:u3}] {Message:lj} {NewLine}{Exception}";
        private static string _templateWithCaller = "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level:u3}] {Message:lj} (Method: {SourceMember}, File: {SourceFile}, Line: {SourceLine}){NewLine}{Exception}";

        static LogManager() {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Logger(l => l.Filter.ByIncludingOnly(e => e.Level == LogEventLevel.Information)
                    .WriteTo.File(@"Logs\Info_.log", outputTemplate: _templateWithoutCaller, rollingInterval: RollingInterval.Day, retainedFileCountLimit: null))
                .WriteTo.Logger(l => l.Filter.ByIncludingOnly(e => e.Level == LogEventLevel.Debug)
                    .WriteTo.File(@"Logs\Debug_.log", outputTemplate: _templateWithoutCaller, rollingInterval: RollingInterval.Day, retainedFileCountLimit: null))
                .WriteTo.Logger(l => l.Filter.ByIncludingOnly(e => e.Level == LogEventLevel.Warning)
                    .WriteTo.File(@"Logs\Warning_.log", outputTemplate: _templateWithoutCaller, rollingInterval: RollingInterval.Day, retainedFileCountLimit: null))
                .WriteTo.Logger(l => l.Filter.ByIncludingOnly(e => e.Level == LogEventLevel.Error)
                    .WriteTo.File(@"Logs\Error_.log", outputTemplate: _templateWithoutCaller, rollingInterval: RollingInterval.Day, retainedFileCountLimit: null))
                .WriteTo.File(@"Logs\Verbose_.log", outputTemplate: _templateWithoutCaller, rollingInterval: RollingInterval.Day, retainedFileCountLimit: null)
                .CreateLogger();
        }

        public static void LogDebug(string message) {
            Log.Debug(message);
        }

        public static void LogInformation(string message) {
            Log.Information(message);
        }

        public static void LogWarning(string message) {
            Log.Warning(message);
        }

        public static void LogError(string message) {
            Log.Error(message);
        }

        public static void LogError(string message, Exception exception) {
            Log.Error(messageTemplate: message, exception: exception);
        }
    }
}