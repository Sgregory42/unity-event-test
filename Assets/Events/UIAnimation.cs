using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnChanged(string something_that_changed)
    {
        Debug.Log($"Animation ui something changed : {something_that_changed}");
    }
}
