using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            weatherStation weatherStation= new weatherStation(10,11,16);
           
            User user = new User("User",new fahrenheit());
            User user1 = new User("User1",new Celcius()); 
            User user2 = new User("User2",new fahrenheit()); 
            User user3 = new User("User3",new Celcius());

            weatherStation.subscribe(user, weatherStation.eventTypes.All);
            weatherStation.subscribe(user1, weatherStation.eventTypes.All);
            weatherStation.subscribe(user2, weatherStation.eventTypes.Min);
            weatherStation.subscribe(user3, weatherStation.eventTypes.Max);
            weatherStation.unsubscribe(user, weatherStation.eventTypes.All);

            Console.WriteLine("increased temperature to 12");
            weatherStation.Temperature = 12;

            Console.WriteLine("decreased temperature to -1");
            weatherStation.Temperature = -1;
            

            Console.WriteLine("Unsubscribed user3 from max listener \n ");
            weatherStation.unsubscribe(user3, weatherStation.eventTypes.Max);

            Console.WriteLine("Temperature increased to 13");
            weatherStation.Temperature = 13;
            Console.ReadKey();


            fahrenheit f = new fahrenheit();
            f.print(weatherStation.history);
        }
    }
}
