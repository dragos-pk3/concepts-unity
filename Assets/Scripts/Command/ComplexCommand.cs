
using UnityEngine;

public class ComplexCommand : MonoBehaviour, ICommand
{
    private Receiver _receiver;
    private string _a;
    private string _b;

    public ComplexCommand(Receiver receiver, string a, string b)
    {
        _receiver = receiver;
        _a = a;
        _b = b;
    }

    public void Execute()
    {
        Debug.Log("ComplexCommand: Complex stuff should be done by a receiver object.");
        _receiver.DoSomething(_a);
        _receiver.DoSomethingElse(_b);
    }

}