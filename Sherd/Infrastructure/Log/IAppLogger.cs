using Serilog.Events;
using System;

namespace Infrastructure.Log
{
    public interface IAppLogger
    {
        void Write(LogEventLevel level, Exception exception, string messageTemplate, params object[] propertyValues);
        void Write(LogEvent logEvent);
        void Write(LogEventLevel level, string messageTemplate);
        void Write<T>(LogEventLevel level, string messageTemplate, T propertyValue);
        void Write<T0, T1, T2>(LogEventLevel level, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2);
        void Write(LogEventLevel level, string messageTemplate, params object[] propertyValues);
        void Write<T>(LogEventLevel level, Exception exception, string messageTemplate, T propertyValue);
        void Write<T0, T1>(LogEventLevel level, Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1);
        void Write<T0, T1, T2>(LogEventLevel level, Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2);
        void Write<T0, T1>(LogEventLevel level, string messageTemplate, T0 propertyValue0, T1 propertyValue1);
        void Write(LogEventLevel level, Exception exception, string messageTemplate);
    }
}
