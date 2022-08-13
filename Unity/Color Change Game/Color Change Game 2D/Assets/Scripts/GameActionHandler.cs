using UnityEngine.Events;
using UnityEngine;

public class GameActionHandler : MonoBehaviour
{
    public GameAction gameActionObj;
    public UnityEvent onRaiseEvent;

    private void Start()
    {
        gameActionObj.raise += Raise;
    }

    private void Raise()
    {
        onRaiseEvent.Invoke();
    }
}
