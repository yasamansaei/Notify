using MongoDB.Bson;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace Notify.Common.Infrastracture.Entitites
{
    [Collection("sms_tracker")]
    public class SmsTracker
    {
        public ObjectId TrackerId { get; set; }
        public string Mobile{ get; set; }
        public string Message{ get; set; }
        public SmsStatus SmsStatus{ get; set; }
        public DateTime CreateOn{ get; set; }
    }

    public enum SmsStatus
    {
        Sent,
        Failed,
        Deliverd
    }
}
