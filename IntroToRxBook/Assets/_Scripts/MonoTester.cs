using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class MonoTester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
       //var observer = new MyConsoleObserver<int>();
       //var numbers = new MySequenceOfNumbers();
       // numbers.Subscribe(observer);
       var subject = new Subject<string>();
       //PrintSequenceToConsole(subject);
       subject.Subscribe(value => Debug.Log(value));
       subject.OnNext("a");
       subject.OnNext("b");
       subject.OnNext("c");
       subject.OnCompleted();
    }

        
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
