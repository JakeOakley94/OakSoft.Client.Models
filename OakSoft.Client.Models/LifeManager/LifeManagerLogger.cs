using OakSoftCore;
using OakSoftCore.Logging;

namespace OakSoft.Client.Models
{
    public class LifeManagerLogger : Logger
    {
        private ICollection<LogSeverity> _severities;

        public LifeManagerLogger(string logPath) : base(logPath)
        {
            AddAllSeverities();
        }

        public LifeManagerLogger(string logPath, LogSettings logSettings) : base(logPath)
        {
            GetSeverities(logSettings);
        }

        private void AddAllSeverities()
        {
            _severities = new List<LogSeverity>(); 
            _severities.Add(LogSeverity.SystemMustLog);
            _severities.Add(LogSeverity.Error);
            _severities.Add(LogSeverity.Information);
            _severities.Add(LogSeverity.Warning);
        }

        private void GetSeverities(LogSettings logSettings)
        {
            _severities = new List<LogSeverity>();
            _severities.Add(LogSeverity.SystemMustLog);
            if (logSettings.UseLogging is false) return;
            if (logSettings.Error) _severities.Add(LogSeverity.Error);
            if (logSettings.Information) _severities.Add(LogSeverity.Information);
            if (logSettings.Warning) _severities.Add(LogSeverity.Warning);
        }

        public override void WriteToLog(LogSeverity severity, string message, bool includeCurrentDate = true, bool append = true)
        {
            if (_severities.Any(x => x == severity))
            {
                base.WriteToLog(severity, message, includeCurrentDate);
            }
        }
    }
}
