using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class weatherStation : observable
    {
        public enum eventTypes
        {
            All,
            Min,
            Max
        }

        private double temperature;
        private double humidity;
        private double pressure;

        private List<weatherStationObserver> observerList = new List<weatherStationObserver>();

        public List<ChangeTracker> history = new List<ChangeTracker>();

        public weatherStation(double atemp, double ahumidity, double apressure)
        {
            this.temperature = atemp;
            this.humidity = ahumidity;
            this.pressure = apressure;
            this.history.Add(new ChangeTracker(ChangeTracker.Types.Humidity, ahumidity));
            this.history.Add(new ChangeTracker(ChangeTracker.Types.Temperature, atemp));
            this.history.Add(new ChangeTracker(ChangeTracker.Types.Pressure, apressure));
        }

        public double Temperature
        {
            get { return temperature; }
            set
            {
                this.temperature = value;
                this.notify();
                this.history.Add(new ChangeTracker(ChangeTracker.Types.Temperature, value));
            }
        }

        public double Humidity
        {
            get { return humidity; }
            set
            {
                this.humidity = value;
                this.notify();
                this.history.Add(new ChangeTracker(ChangeTracker.Types.Humidity, value));
            }
        }

        public double Pressure
        {
            get { return pressure; }
            set
            {
                this.history.Add(new ChangeTracker(ChangeTracker.Types.Pressure, value));
                this.pressure = value;
                this.notify();
            }
        }

        public void notify(weatherStation.eventTypes event_type = eventTypes.All)
        {
            foreach (weatherStationObserver weatherStationObserver in this.observerList)
            {
                if (weatherStationObserver.eventName == event_type)
                {
                    weatherStationObserver.user.update(this, weatherStationObserver);
                }
            }
        }

        public void subscribe(User observer, weatherStation.eventTypes eventType)
        {
            this.observerList.Add(new weatherStationObserver(observer, eventType));
        }

        public void unsubscribe(User observer, weatherStation.eventTypes eventType)
        {
            this.observerList.Remove(new weatherStationObserver(observer, eventType));
        }
    }
}
