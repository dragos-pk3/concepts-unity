using UnityEngine;

public class Player : MonoBehaviour
{
    public SignalEnum signalToBroadcast = SignalEnum.OnPlayerDeath;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) // Simulate event trigger
        {
            Debug.Log("Broadcasting signal: " + signalToBroadcast);
            SignalManager.Broadcast(signalToBroadcast, null);
        }
    }
}