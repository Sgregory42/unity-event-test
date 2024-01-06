using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeProcessor : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnAttributChange(string name)
    {
        Debug.Log($"Goal processor attribut or game object changed : {name}");
    }
}
