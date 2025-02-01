

using UnityEngine;
public class Invoker : MonoBehaviour
{
    private ICommand _onStart;
    private ICommand _onFinish;

    public void SetOnStart(ICommand command)
    {
        _onStart = command;
    }

    public void SetOnFinish(ICommand command)
    {
        _onFinish = command;
    }


    public void DoSomethingImportant()
    {
        Debug.Log("Invoker: Does anybody want something done before I begin?");
        if (_onStart is ICommand)
        {
            _onStart.Execute();
        }
        Debug.Log("Invoker: ...doing something really important...");
        Debug.Log("Invoker: Does anybody want something done after I finish?");
        if (_onFinish is ICommand)
        {
            _onFinish.Execute();
        }
    }
}