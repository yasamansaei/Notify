namespace Notify.Features.Sms;
public interface ISmsProvider
{
    Task<string> SendAsync(string mobile , string message);
    Task<bool> InquiryAsync(string SmsTrackerId);
}

