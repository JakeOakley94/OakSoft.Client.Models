using System.Drawing;

namespace OakSoft.Client.Models
{

    public class LifeManagerSettings
    {
        public LogSettings LogSettings { get; set; }
        public FeatureSettings FeatureSettings { get; set; }

        public LifeManagerSettings()
        {
            LogSettings = new LogSettings();
            FeatureSettings = new FeatureSettings();
        }
    }

    public class LogSettings
    {
        public bool UseLogging { get; set; }
        public bool Information { get; set; }
        public bool Warning { get; set; }
        public bool Error { get; set; }

        public LogSettings()
        {
            UseLogging = true;
            Error = true;
        }
    }

    public class ScheduleSettings
    {

    }

    public class HouseholdSettings
    {

    }

    public class DocumentSettings
    {

    }

    public class FeatureSettings
    {
        public HouseholdSettings HouseholdSettings { get; set; }
        public DocumentSettings DocumentSettings { get; set; }
        public ScheduleSettings ScheduleSettings { get; set; }
    }


}
