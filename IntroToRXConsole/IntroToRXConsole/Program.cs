using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToRXConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            var interval = Observable.Interval(TimeSpan.FromMilliseconds(250));
            interval.Subscribe(
                Console.WriteLine,
                () => Console.WriteLine("completed"));
            while (true)
            {
                
            }
        }
    }
}
