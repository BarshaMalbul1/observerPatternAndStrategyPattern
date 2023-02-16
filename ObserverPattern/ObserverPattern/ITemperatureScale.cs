using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface ITemperatureScale
    {
       void print(List<ChangeTracker> history);

       double convert(double value);

       List<KeyValuePair<string, double>> calculate(List<ChangeTracker> history);

    }
}
