namespace Events.Models.Settings
{
    public class AppSettings
    {
        public KestrelSettings Kestrel { get; set; }

        public ConnectionSettings Connection { get; set; }
    }
}
