namespace Notify
{
    public partial class FeaturesConfigurations
    {
        public SmsConfiguration Sms { get; set; } = null!;
    }

    public class SmsConfiguration
    {
        public FarapayamakConfiguration Farapayamak { get; set; } = null!;
    }

    public class FarapayamakConfiguration
    {
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public required string Mobile { get; set; }
    }
}
