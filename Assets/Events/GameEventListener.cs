
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    // Start is called before the first frame update
    public EventRegistry eventRegistry;

    public UnityEvent<string> onChangedEvent;

    private void OnEnable()
    {
        eventRegistry.RegisterListener(this);
    }

    private void OnDisable()
    {
        eventRegistry.UnregisterListener(this);
    }

    public void OnEventRaised(string name_of_what_changed)
    {
        Debug.Log($" GameventListener onEventRaised :  {name_of_what_changed}");
        // NO COMMIT : handle error shouldn't be null at start.
        onChangedEvent?.Invoke(name_of_what_changed);
    }
}
