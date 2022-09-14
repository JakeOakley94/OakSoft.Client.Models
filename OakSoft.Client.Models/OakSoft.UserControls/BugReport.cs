using System.Collections.Generic;

namespace OakSoft.Client.Models
{
    public class BugReport
    {
        public int ApplicationId { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string StepsToReproduce { get; set; }
        public int PriorityId { get; set; }
        public string Username { get; set; }
        public string UserEmail { get; set; }
        public string UserPhoneNumber { get; set; }
        public List<BugReportAttachment> Attachments { get; set; }
    }
}
