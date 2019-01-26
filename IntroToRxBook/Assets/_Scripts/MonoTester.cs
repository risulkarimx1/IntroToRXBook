using UniRx;
using UnityEngine;

public class MonoTester : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var subject = new AsyncSubject<string>();
        subject.OnNext("b");
        subject.OnNext("c");
        subject.Subscribe(value => Debug.Log(value));
        subject.OnNext("x");
        subject.OnNext("y");
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
