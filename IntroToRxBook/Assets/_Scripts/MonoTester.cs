﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Timers;
using UnityEngine;
using  System.Reactive.Linq;
public class MonoTester : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {

        

    }

    //public IObservable<int> Range(int start, int count)
    //{
    //    var max = start + count;
    //    return System.Reactive.Linq.Observable.Generate(
    //        start,
    //        value => value < max,
    //        value => value + 1,
    //        value => value);
    //}
    /*
     *var range = Observable.Range(10, 15);
        range.Subscribe(v=> Debug.Log($"{v}"));
     */
    /*
     
        var naturalNumeber = Unfold(1, i => i + 1);
        Debug.Log($"first ten number");
        foreach (var number in naturalNumeber.Take(10))
        {
            Debug.Log($"{number}");
        }
     *private IEnumerable<T> Unfold<T>(T seed, Func<T, T> accumulator)
    {
        var nextValue = seed;
        while (true)
        {
            yield return nextValue;
            nextValue = accumulator(nextValue);
        }
    }
     */



    /*
     *    NonBlocking_event_driven();

    public void NonBlocking_event_driven()
    {
        var ob = Observable.Create<string>(
            observer =>
            {
                var timer = new System.Timers.Timer();
                timer.Interval = 1000;
                timer.Elapsed += (s, e) => observer.OnNext("tick");
                timer.Elapsed += OnTimerElapsed;
                timer.Start();
                return timer;
            });
        var subscription = ob.Subscribe(Console.WriteLine);
        Console.ReadLine();
        subscription.Dispose();
    }
     */

    private void OnTimerElapsed(object sender, ElapsedEventArgs e)
    {
        Console.WriteLine(e.SignalTime);
    }
    /*
     *public static IObservable<T> Empty<T>()
    {
        return Observable.Create<T>(
        observer=>
        {
            observer.OnCompleted();
            return Disposable.Empty;
        });
    }

    public static IObservable<T> Return<T>(T tvalue)
    {
        return Observable.Create<T>(ob =>
        {
            ob.OnNext(tvalue);
            ob.OnCompleted();
            return Disposable.Empty;
        });
    }
     */

    /*
     NonBlocking().Subscribe(v => Debug.Log(v));

     *private IObservable<string> NonBlocking()
    {
        return Observable.Create<string>(
            (IObserver<string> observer) =>
            {
                observer.OnNext("a");
                observer.OnNext("b");
                observer.OnCompleted();
                Thread.Sleep(1000);
                return Disposable.Create(() => Console.WriteLine("Observer Unsubed"));
            });
    }
     */
    /*
     *private IObservable<string> BlockingMethod()
    {
        var subject = new ReplaySubject<string>();
        subject.OnNext("a");
        subject.OnNext("b");
        subject.OnCompleted();
        Thread.Sleep(1000);
        return subject;
    }
     */



    /*
     *var throwingObservable = Observable.Throw<string>(new Exception());
        throwingObservable.Subscribe(v => Debug.Log(v));
        // Equaivalent code by Subject is 
        //var throwingSubject = new Subject<string>();
        //throwingSubject.Subscribe(v => Debug.Log(v));
        //throwingSubject.OnNext("a");
        //throwingSubject.OnError(new Exception());
     */
    /*
     *var never = Observable.Never<string>();
        never.Subscribe(v => Debug.Log($"value at time {Time.time} is {v}"));
        // equavalent code using subject is: Subject with out notification 
        var subject = new Subject<string>();
     */
    /*
     *  var singleValue = Observable.Return<String>("value");
        singleValue.Subscribe(v => Debug.Log(v));
        // this could also be simulated with ReplaySubject
        //var subject = new ReplaySubject<string>();
        //subject.OnNext("value");
        //subject.OnCompleted();
     */

    /*void HeavyWork(string workName)
    {
        Debug.Log($"doing {workName}");
        Thread.Sleep(1000);
    }*/
    /*using (new TimeIT("Outer scope"))
    {
        using (new TimeIT("Inner scope A"))
        {
            HeavyWork("A");
        }

        using (new TimeIT("Inner scope B"))
        {
            HeavyWork("B");
        }

        Debug.Log($"Cleaning up");
    }*/

    /*
     * var values = new Subject<int>();
        var firstSub = values.Subscribe(value => Debug.Log($"First Sub received {value} at {Time.time}ms"));
        var second = values.Subscribe(value => Debug.Log($"Second Sub received {value} at {Time.time}ms"));

        values.OnNext(0);
        values.OnNext(1);
        values.OnNext(2);
        firstSub.Dispose();
        values.OnNext(3);
     */

    /*
     * var values = new Subject<int>();
        try
        {
            values.Subscribe(
                value=>Debug.Log(value),
                ex =>Debug.LogError($"Exception Handled {ex.ToString()}")
                );
        }
        catch (Exception e)
        {
            Debug.Log($"wont catch anything here {e.ToString()}");
        }
        values.OnNext(0);
        values.OnError(new Exception("Dummy exception"));
     */

    //var subject = new AsyncSubject<string>();
    //subject.OnNext("b");
    //subject.OnNext("c");
    //subject.Subscribe(value => Debug.Log(value));
    //subject.OnNext("x");
    //subject.OnNext("y");
    //subject.OnCompleted();

    //void PrintSequenceToConsole(IObservable<string> seq)
    //{
    //    seq.Subscribe(value=>Debug.Log(value));
    //}
    //IObservable<string> DebugLog(string value)
    //{
    //   Debug.Log(value);
    //   return new IObservable<string>();
    //}

}
