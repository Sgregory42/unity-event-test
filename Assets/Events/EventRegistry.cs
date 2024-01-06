using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "MyEvent")]
public class EventRegistry : ScriptableObject
{
    private List<GameEventListener> _listeners = new();

    public void RegisterListener(GameEventListener listener)
    {

        UnregisterListener(listener);
        _listeners.Add(listener);
    }

    public void UnregisterListener(GameEventListener listener)
    {
        _listeners.Remove(listener);
    }

    public void OnChanged(string name_of_gameobject_that_changed)
    {
        Debug.Log($"EventRegistry calling listeners with changed : {name_of_gameobject_that_changed}");
        for (int i = _listeners.Count - 1; i >= 0; i--)
        { // Reverse iteration in case listener unregister in the OnEvenRaised
            _listeners[i].OnEventRaised(name_of_gameobject_that_changed);
        }
    }
}