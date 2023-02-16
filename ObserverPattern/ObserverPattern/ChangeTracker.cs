using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ChangeTracker
    {
        public enum Types
        {
            Temperature,
            Humidity,
            Pressure
        }

       
        public string type = "";
        public double value = 0.0;

        public ChangeTracker(Types a, double value)
        {
            this.type = a.ToString();
            this.value = value;
        }

    }
}
