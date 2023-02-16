using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Celcius: Calculator,ITemperatureScale
    {
        public void print(List<ChangeTracker> changes)
        {
            List<KeyValuePair<String, double>> results = this.calculate(changes);
            string to_print = "";
            foreach (var history in results)
            {
                to_print += history.Key.Replace(" ", "_") + " is " + this.convert(history.Value).ToString() + "\n \n";
            }
            Console.WriteLine(to_print);
        }

        public double convert(double a)
        {
            return a;
        }
    }
}
