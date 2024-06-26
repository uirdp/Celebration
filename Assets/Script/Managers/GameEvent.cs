using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//GameEvent has listners, 
[CreateAssetMenu]
public class GameEvent : ScriptableObject
{
    private List<GameEventListener> listeners =
        new List<GameEventListener>();


    //when event occured, invokes all listeners
    public void Raise()
    {
        for(int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListner(GameEventListener listener)
    {
        listeners.Add(listener);
    }
    
    public void UnregisterListner(GameEventListener listener)
    {
        listeners.Remove(listener);
    }
}
