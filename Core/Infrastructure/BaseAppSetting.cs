namespace Infrastructure
{
    public class BaseAppSetting
    {
        public CorsSetting CorsSetting { get; set; }
        public ConnectionString ConnectionString { get; set; }
    }

    public class ConnectionString
    {
        public string Value { get; set; }
    }

    public class CorsSetting
    {
        public string CorsPolicy { get; set; }
        public string Origins { get; set; }
        public string[] Methods { get; set; }
        public string[] Headers { get; set; }
    }
}
