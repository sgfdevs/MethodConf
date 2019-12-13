namespace MethodConf.Classes
{
    public class Session
    {
        public string Title { get; set; }
        public string TimeLabel { get; set; }
        public string Description { get; set; }
        public Speaker Speaker { get; set; }
        public SessionType SessionType { get; set; }
    }

    public enum SessionType
    {
        Main,
        Workshop,
        Lunch,
        Keynote
    }
}