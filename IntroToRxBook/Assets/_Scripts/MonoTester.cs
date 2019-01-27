using System;
using System.Threading;
using UniRx;
using UnityEngine;

public class MonoTester : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        using (new TimeIT("Outer scope"))
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
        }
    }

    void HeavyWork(string workName)
    {
        Debug.Log($"doing {workName}");
        Thread.Sleep(1000);
    }

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
