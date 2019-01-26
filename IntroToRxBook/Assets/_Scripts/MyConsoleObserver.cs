using System;
using  UnityEngine;
public class MyConsoleObserver<T> : IObserver<T>
{
    public void OnCompleted()
    {
        Debug.Log($"Sequence ended");
    }
    public void OnError(Exception error)
    {
        Debug.Log($"Sequence failed with error: {error}");
    }
    public void OnNext(T value)
    {
        Debug.Log($"Received value: {value}");
    }
}
