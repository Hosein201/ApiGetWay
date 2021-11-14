namespace Infrastructure
{
    public class Setting
    {
        public CorsSetting CorsSetting { get; set; }
    }

    public class CorsSetting
    {
        public string CorsPolicy { get; set; }
        public string Origins { get; set; }
        public string[] Methods { get; set; }
        public string[] Headers { get; set; }
    }
}
