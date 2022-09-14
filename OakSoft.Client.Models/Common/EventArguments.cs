namespace OakSoft.Client.Models
{
    public class EventArguments
    {
        public Guid GuidArg { get; set; }
        public string StringArg { get; set; }

        public EventArguments()
        {

        }

        public EventArguments(Guid guidArg)
        {
            GuidArg = guidArg;
        }

        public EventArguments(string stringArg)
        {
            StringArg = stringArg;
        }
    }

}
