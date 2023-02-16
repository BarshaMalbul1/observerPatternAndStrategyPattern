using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class User : Observer
    {
        public string name = "";
        private ITemperatureScale Temperatureformat;
        public User(string aname, ITemperatureScale Temperatureformat)
        {
            this.name = aname;
            this.Temperatureformat = Temperatureformat;
        }
        public void update(weatherStation obj, weatherStationObserver wso)
        {
            Console.WriteLine("\n \n Updating user " + wso.user.name + " for " + wso.eventName.ToString() + "\n");
            //prints the converted information
            this.Temperatureformat.print(obj.history);
        }
    }

}