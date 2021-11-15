namespace Infrastructure
{
    public class SettingMicroService
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

    public class SettingGetWay
    {
        public ConnectionString ConnectionString { get; set; }
        public JwtSettings JwtSettings { get; set; }
    }

    public class ConnectionString
    {
        public string Value { get; set; }
    }

    public class JwtSettings
    {
        public string Encryptkey { get; set; }
        public string SecretKey { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public double NotBeforeMinutes { get; set; }
        public double ExpirationMinutes { get; set; }
    }
}
