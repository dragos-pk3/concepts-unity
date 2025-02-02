using UnityEngine;

public class SignalBroadcaster : MonoBehaviour
{
    public SignalEnum signalToBroadcast = SignalEnum.OnPlayerDamaged;
    public int damageAmount = 10;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Simulate event trigger
        {
            Debug.Log("Broadcasting signal: " + signalToBroadcast);
            SignalManager.Broadcast(signalToBroadcast, damageAmount);
        }
    }
}