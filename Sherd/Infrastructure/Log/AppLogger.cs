using Serilog;
using Serilog.Events;
using System;

namespace Infrastructure.Log
{
    public class AppLogger : IAppLogger
    {
        public ILogger Logger { get; set; }
        public AppLogger(ILogger logger)
        {
            Logger = logger;
        }

        // Summary:
        //     Write a log event with the specified level and associated exception.
        //
        // Parameters:
        //   level:
        //     The level of the event.
        //
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValues:
        //     Objects positionally formatted into the message template.
        public void WriteLogg(LogEventLevel level, Exception exception, string messageTemplate, params object[] propertyValues)
        {
            Logger.Write(level, exception, messageTemplate, propertyValues);
        }

        // Summary:
        //     Write an event to the log.
        //
        // Parameters:
        //   logEvent:
        //     The event to write.
        public void WriteLogg(LogEvent logEvent)
        {
            Logger.Write(logEvent);
        }

        // Summary:
        //     Write a log event with the specified level.
        //
        // Parameters:
        //   level:
        //     The level of the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        public void WriteLogg(LogEventLevel level, string messageTemplate)
        {
            Logger.Write(level, messageTemplate);
        }

        // Summary:
        //     Write a log event with the specified level.
        //
        // Parameters:
        //   level:
        //     The level of the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue:
        //     Object positionally formatted into the message template.
        public void WriteLogg<T>(LogEventLevel level, string messageTemplate, T propertyValue)
        {
            Logger.Write(level, messageTemplate, propertyValue);
        }

        // Summary:
        //     Write a log event with the specified level.
        //
        // Parameters:
        //   level:
        //     The level of the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue2:
        //     Object positionally formatted into the message template.
        public void WriteLogg<T0, T1, T2>(LogEventLevel level, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            Logger.Write(level, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        // Summary:
        //     Write a log event with the specified level.
        //
        // Parameters:
        //   level:
        //     The level of the event.
        //
        //   messageTemplate:
        //
        //   propertyValues:
        public void WriteLogg(LogEventLevel level, string messageTemplate, params object[] propertyValues)
        {
            Logger.Write(level, messageTemplate, propertyValues);
        }

        // Summary:
        //     Write a log event with the specified level and associated exception.
        //
        // Parameters:
        //   level:
        //     The level of the event.
        //
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue:
        //     Object positionally formatted into the message template.
        public void WriteLogg<T>(LogEventLevel level, Exception exception, string messageTemplate, T propertyValue)
        {
            Logger.Write(level, exception, messageTemplate, propertyValue);
        }

        // Summary:
        //     Write a log event with the specified level and associated exception.
        //
        // Parameters:
        //   level:
        //     The level of the event.
        //
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        public void WriteLogg<T0, T1>(LogEventLevel level, Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Logger.Write(level, exception, messageTemplate, propertyValue0, propertyValue1);
        }

        // Summary:
        //     Write a log event with the specified level and associated exception.
        //
        // Parameters:
        //   level:
        //     The level of the event.
        //
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue2:
        //     Object positionally formatted into the message template.
        public void WriteLogg<T0, T1, T2>(LogEventLevel level, Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1,
            T2 propertyValue2)
        {
            Logger.Write(level, exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        // Summary:
        //     Write a log event with the specified level.
        //
        // Parameters:
        //   level:
        //     The level of the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        public void WriteLogg<T0, T1>(LogEventLevel level, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            Logger.Write(level, messageTemplate, propertyValue0, propertyValue1);
        }

        // Summary:
        //     Write a log event with the specified level and associated exception.
        //
        // Parameters:
        //   level:
        //     The level of the event.
        //
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        public void WriteLogg(LogEventLevel level, Exception exception, string messageTemplate)
        {
            Logger.Write(level, exception, messageTemplate);
        }
    }
}