using System;
using System.Reactive.Linq;

namespace IntroToRXConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Timer(TimeSpan.FromSeconds(1)).Subscribe(Console.WriteLine);
            while (true) ;
        }

        public static IObservable<long> Timer(TimeSpan dueTime)
        {
            return Observable.Generate(
                0l,
                i=>i<1,
                i=>i+1,
                i=>i,
                i=>dueTime
                );
        }
        /*
     *Interval(TimeSpan.FromSeconds(2)).Subscribe(Console.WriteLine);
            while (true) ;
            public static IObservable<long> Interval(TimeSpan period)
        {
            return Observable.Timer(period, period);
        }
     */



        /*
     * var timer = Observable.Timer(TimeSpan.FromSeconds(1));
            timer.Subscribe(
                Console.WriteLine,
                () => Console.WriteLine("completed"));

            while (true) ;
     */
        //Example code only
        public static IObservable<int> Range(int start, int count)
        {
            int max = start + count;
            return Observable.Generate(
                start,
                value => value < max,
                value => value + 1,
                value => value);
        }

    }
}
