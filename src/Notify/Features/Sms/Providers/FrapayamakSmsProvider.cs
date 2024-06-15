using PayamakCore.Dto;
using PayamakCore.Interface;

namespace Notify.Features.Sms.Providers;

public class FrapayamakSmsProvider(IPayamakServices payamakServices,IOptions<AppSettings> options) : ISmsProvider
{
    private readonly IPayamakServices _payamakServices=payamakServices;
    private readonly FarapayamakConfiguration farapayamak = options.Value.Features.Sms.Farapayamak;

    public async Task<string> SendAsync(string mobile, string message)
    {
        var result = await _payamakServices.SendSms(new MessageDto
        {
            From = farapayamak.Mobile,
            To = mobile,
            Text = message,
            username = farapayamak.UserName,
            password = farapayamak.Password
        });
        return result.Value;
    }
    public async Task<bool> InquiryAsync(string SmsTrackerId)
    {
        var _id = Convert.ToInt64(SmsTrackerId);
       var result=await _payamakServices.GetMessageStatus(new DeliverRequestDto()
       {
           password = farapayamak.Password,
           RecId = _id,
           username=farapayamak.UserName,
          
       });
        return result.RetStatus>0;
    }
}
