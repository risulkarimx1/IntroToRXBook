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
       var subject = new ReplaySubject<string>();
       
       subject.OnNext($"a {Time.time}");
       subject.Subscribe(value => Debug.Log(value));
        subject.OnNext($"b {Time.time}");
       subject.OnNext($"c {Time.time}");
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
