using UnityEngine;

public class PlayerListener : MonoBehaviour
{
    public SignalEnum signalToListenFor = SignalEnum.OnPlayerDeath;

    private void OnEnable()
    {
        SignalManager.Subscribe(signalToListenFor, OnSignalReceived);
    }

    private void OnDisable()
    {
        SignalManager.Unsubscribe(signalToListenFor, OnSignalReceived);
    }

    private void OnSignalReceived(object data)
    {
        Debug.Log(gameObject.name + " received signal: " + signalToListenFor + " with data: " + data);
        Debug.Log("Player Dead");
    }
}