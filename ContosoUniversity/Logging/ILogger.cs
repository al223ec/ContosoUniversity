using System;

namespace ContosoUniversity.Logging
{
    //http://www.asp.net/aspnet/overview/developing-apps-with-windows-azure/building-real-world-cloud-apps-with-windows-azure/monitoring-and-telemetry#log
    //A best practice for logging is to do it by using an interface rather than hard-coding calls to 
    //System.Diagnostics.Trace or a logging class. That makes it easier to change your logging mechanism later 
    //if you ever need to do that. So in this section you'll create the logging interface and a class to implement it
    public interface ILogger
    {
        void Information(string message);
        void Information(string fmt, params object[] vars);
        void Information(Exception exception, string fmt, params object[] vars);

        void Warning(string message);
        void Warning(string fmt, params object[] vars);
        void Warning(Exception exception, string fmt, params object[] vars);

        void Error(string message);
        void Error(string fmt, params object[] vars);
        void Error(Exception exception, string fmt, params object[] vars);

        void TraceApi(string componentName, string method, TimeSpan timespan);
        void TraceApi(string componentName, string method, TimeSpan timespan, string properties);
        void TraceApi(string componentName, string method, TimeSpan timespan, string fmt, params object[] vars);

    }
}