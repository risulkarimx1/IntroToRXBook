using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class TimeIT : IDisposable
{
    private readonly string _name;
    private readonly Stopwatch _watch;

    public TimeIT(string name)
    {
        
        _name = name;
        _watch = Stopwatch.StartNew();
    }

    public void Dispose()
    {
        _watch.Stop();
        Debug.Log($"{_name} took {_watch.Elapsed}");
    }
}
