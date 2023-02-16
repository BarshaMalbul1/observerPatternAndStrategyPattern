using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface observable
    {
        void subscribe(User ob, weatherStation.eventTypes eventType);
        void unsubscribe(User ob, weatherStation.eventTypes eventType);
        void notify(weatherStation.eventTypes event_type);
    }
}
