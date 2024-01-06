using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    // Start is called before the first frame update

    public EventRegistry registry;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp()
    {
       
        
        Debug.Log($"CLicked on {transform.gameObject.name}");
        registry.OnChanged(transform.gameObject.name);
    }
}
