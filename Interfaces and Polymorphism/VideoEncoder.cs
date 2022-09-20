using System.Collections.Generic;

namespace Interfaces_and_Polymorphism
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationsChannels;
        public VideoEncoder()
        {
            _notificationsChannels = new List<INotificationChannel>();
        }
        public void Encode(Video video) 
        {
            //Video encoding logic
            //...
            foreach (var channel in _notificationsChannels)
            {
                channel.Send(new Message());
            }
        }
        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationsChannels.Add(channel);
        }
    }
}
