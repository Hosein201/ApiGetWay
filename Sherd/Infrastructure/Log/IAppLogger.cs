using Serilog.Events;
using System;

namespace Infrastructure.Log
{
    public interface IAppLogger
    {
        void WriteLogg(LogEventLevel level, Exception exception, string messageTemplate, params object[] propertyValues);
        void WriteLogg(LogEvent logEvent);
        void WriteLogg(LogEventLevel level, string messageTemplate);
        void WriteLogg<T>(LogEventLevel level, string messageTemplate, T propertyValue);
        void WriteLogg<T0, T1, T2>(LogEventLevel level, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2);
        void WriteLogg(LogEventLevel level, string messageTemplate, params object[] propertyValues);
        void WriteLogg<T>(LogEventLevel level, Exception exception, string messageTemplate, T propertyValue);
        void WriteLogg<T0, T1>(LogEventLevel level, Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1);
        void WriteLogg<T0, T1, T2>(LogEventLevel level, Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2);
        void WriteLogg<T0, T1>(LogEventLevel level, string messageTemplate, T0 propertyValue0, T1 propertyValue1);
        void WriteLogg(LogEventLevel level, Exception exception, string messageTemplate);
    }
}
