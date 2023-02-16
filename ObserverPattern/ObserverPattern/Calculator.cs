using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Calculator
    {

        public List<KeyValuePair<string, double>> calculate(List<ChangeTracker> history)
        {
            //initialize some variables to store
            //average, max ,min * temp, humidity, pressure
            List<KeyValuePair<string, double>> return_list = new List<KeyValuePair<string, double>>();
            double minTemperature = 0.0;
            double maxTemperature = 0.0;
            double minHumidity = 0.0;
            double maxHumidity = 0.0;
            double minPressure = 0.0;
            double maxPressure = 0.0;
            double AvgTemperature = 0.0;
            double AvgHumidity = 0.0;
            double AvgPressure = 0.0;
            double t_count = 0;
            double p_count = 0;
            double h_count = 0;

            foreach (ChangeTracker h in history)
            {

                if (h.type == ChangeTracker.Types.Temperature.ToString())
                {
                    if (h.value < minTemperature)
                    {
                        minTemperature = h.value;
                    }
                    if (h.value > maxTemperature)
                    {
                        maxTemperature = h.value;
                    }
                    AvgTemperature += h.value;
                    t_count++;

                }

                if (h.type == ChangeTracker.Types.Pressure.ToString())
                {
                    if (h.value < minPressure)
                    {
                        minPressure = h.value;
                    }
                    if (h.value > maxPressure)
                    {
                        maxPressure = h.value;
                    }
                    AvgPressure += h.value;
                    p_count++;
                }

                if (h.type == ChangeTracker.Types.Humidity.ToString())
                {
                    if (h.value < minHumidity)
                    {
                        minHumidity = h.value;
                    }
                    if (h.value > maxHumidity)
                    {
                        maxHumidity = h.value;
                    }
                    AvgHumidity += h.value;
                    h_count++;
                }
            }
            AvgTemperature = AvgTemperature / t_count;
            AvgPressure = AvgPressure / p_count;
            AvgHumidity = AvgHumidity / h_count;

            return_list.Add(new KeyValuePair<string, double>("average_temperature", AvgTemperature));
            return_list.Add(new KeyValuePair<string, double>("average_pressure", AvgPressure));
            return_list.Add(new KeyValuePair<string, double>("average_humidity", AvgHumidity));

            return_list.Add(new KeyValuePair<string, double>("min_temperature", minTemperature));
            return_list.Add(new KeyValuePair<string, double>("min_pressure", minPressure));
            return_list.Add(new KeyValuePair<string, double>("min_humidity", minHumidity));

            return_list.Add(new KeyValuePair<string, double>("max_temperature", maxTemperature));
            return_list.Add(new KeyValuePair<string, double>("max_pressure", maxPressure));
            return_list.Add(new KeyValuePair<string, double>("max_humidity", maxHumidity));

            return return_list;

        }
    }
}

