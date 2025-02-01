

using UnityEngine;

public class SimpleCommand : MonoBehaviour, ICommand
{
    private string _payload = string.Empty;

    public SimpleCommand(string payload)
    {
        _payload = payload;
    }
    public void Execute()
    {
        Debug.Log($"SimpleCommand: See, I can do simple things like printing ({_payload})");
    }
}