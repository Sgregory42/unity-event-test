using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;


public class Data
{
    private EventRegistry registry;
    public Data()
    {


        string[] guids = AssetDatabase.FindAssets("AttributChangeEvent t:EventRegistry");
        if (guids.Length > 0)
        {
            string path = AssetDatabase.GUIDToAssetPath(guids[0]);
            registry = AssetDatabase.LoadAssetAtPath<EventRegistry>(path);
        }

        if (registry == null )
        {
            Debug.LogError("Failed to load registry");
        }
        data = new Dictionary<string, int>();
    }

    public void OnChange(string name)
    {
        registry.OnChanged(name);
    }

    public GameObject parent;
    public int id;
    public Dictionary<string, int> data;
};

public class RandomItem : MonoBehaviour
{
    private Data data;
    private void OnEnable()
    {
        data = new Data();
        data.parent = transform.gameObject;
        data.id = 42;
        data.data["toast"] = 32;
    }

    private void OnDisable()
    {
        data = null;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp()
    {
        Debug.Log($"Onmouse up on {transform.gameObject.name}");
        data.OnChange(transform.gameObject.name);
    }
}
