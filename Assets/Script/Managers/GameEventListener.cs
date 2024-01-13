using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class GameEventListener : MonoBehaviour
{
    public GameEvent Event;
    public UnityEvent Response;

    //when you uncheck the event it automatically will be gone
    private void OnEnable()
    {
        Event.RegisterListner(this);
    }

    private void OnDisable()
    {
        Event.UnregisterListner(this);
    }

    public void OnEventRaised()
    {
        Response.Invoke();
    }
}
