using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class weatherStationObserver
    {
        public User user;
        public weatherStation.eventTypes eventName;
        public weatherStationObserver(User user,weatherStation.eventTypes eventName)
        {
            this.user = user;
            this.eventName = eventName;
        }

    }
}
