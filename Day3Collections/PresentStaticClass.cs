using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

// cannot be instantiated
// can only have static members
// exists only once in memory

namespace Day3Collections
{
    public static class TemperatureConverter
    {
        //Constant - doesn't change

        //static classes cannot have instance constructors (paramaterised)

        //public TemperatureConverter()
        //{
        //}

        //static constructor
        //No access modifiers and parameters
        static TemperatureConverter()
        {
            Console.WriteLine("Static Constructor");
        }

        //cannot declare instance members in static class
        //public int Sum { get; set; }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
    public class Employee
    {
        //static constructor is created and managed by CLR even when not written
        //only when there is a static field

        //static Employee()
        //{
        //    Counter = 100;
        //}

        public static int Counter = 100; 
    }

    //Sealed - other classes cannot inherit static class

    //static class Demo1 : TemperatureConverter
    //{

    //}

    internal class PresentStaticClass
    {
        static void Main(string[] args)
        {
            //No need to instantiate - efficient memory usage
            //no need of multiple objects
            //general purpose

            double f = TemperatureConverter.CelsiusToFahrenheit(25);
            double c = TemperatureConverter.FahrenheitToCelsius(77);

            Console.WriteLine($"25°C = {f}°F");
            Console.WriteLine($"77°F = {c}°C");
        }
    }
}
