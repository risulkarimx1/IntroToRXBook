using System;
using System.Reactive.Linq;
using System.Threading;

namespace IntroToRXConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StartFunc();
            while (true) ;
        }

        static void StartFunc()
        {
            var start = Observable.Start(
                () =>
                {
                    Console.WriteLine("Working in func");
                    for (int i = 0; i < 10; i++)
                    {
                        Thread.Sleep(10);
                        Console.Write(".");
                    }
                    return "Published value";
                }
            );
            start.Subscribe(
                Console.WriteLine,
                ()=>Console.WriteLine("Action complete")
                );
        }

        static void startAction()
        {
            var start = Observable.Start(() =>
            {
                Console.WriteLine("Working in Action");
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(10);
                    Console.Write(".");
                }
            });
            start.Subscribe(
                unit => Console.WriteLine($"{unit} is published"),
                ()=> Console.WriteLine("Action completed")
                );
        }
        /*
     *
            Timer(TimeSpan.FromSeconds(1)).Subscribe(Console.WriteLine);
            while (true) ;
     */
        /*
     *public static IObservable<long> Timer(TimeSpan dueTime)
        {
            return Observable.Generate(
                0l,
                i=>i<1,
                i=>i+1,
                i=>i,
                i=>dueTime
                );
        }
     */
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
