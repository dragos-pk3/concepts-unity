using System.Collections.Generic;
using System;

public static class SignalManager
{
    private static Dictionary<SignalEnum, Action<object>> signalDictionary = new Dictionary<SignalEnum, Action<object>>();

    public static void Subscribe(SignalEnum signal, Action<object> listener)
    {
        if (!signalDictionary.ContainsKey(signal))
        {
            signalDictionary[signal] = delegate { }; 
        }
        signalDictionary[signal] += listener;
    }

    public static void Unsubscribe(SignalEnum signal, Action<object> listener)
    {
        if (signalDictionary.ContainsKey(signal))
        {
            signalDictionary[signal] -= listener;
        }
    }

    public static void Broadcast(SignalEnum signal, object data = null)
    {
        if (signalDictionary.ContainsKey(signal))
        {
            signalDictionary[signal]?.Invoke(data);
        }
    }
}