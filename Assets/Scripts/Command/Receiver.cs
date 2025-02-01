using UnityEngine;
public class Receiver : MonoBehaviour
{
    public void DoSomething(string a)
    {
        Debug.Log($"Receiver: Working on ({a}.)");
    }
    public void DoSomethingElse(string b)
    {
        Debug.Log($"Receiver: Also working on ({b}.)");
    }
}