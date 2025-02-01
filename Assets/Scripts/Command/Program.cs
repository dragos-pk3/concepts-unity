using UnityEngine;

public class Program : MonoBehaviour
{
    private void Start()
    {
        var invoker = new Invoker();
        var receiver = new Receiver();
        invoker.SetOnStart(new SimpleCommand("Say Hi"));
        invoker.SetOnFinish(new ComplexCommand(receiver, "Send", "Receive"));
        invoker.DoSomethingImportant();
    }
}