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


            var timer = Observable.Timer(TimeSpan.FromSeconds(1));
            timer.Subscribe(
                Console.WriteLine,
                () => Console.WriteLine("completed"));

            while (true) ;
        }

        //Example code only
        public static IObservable<int> Range(int start, int count)
        {
            var max = start + count;
            return Observable.Generate(
                start,
                value => value < max,
                value => value + 1,
                value => value);
        }

    }
}
