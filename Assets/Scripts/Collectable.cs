using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public string title;

    public Collectable()
    {
        title = "Default title";
    }

    public Collectable(string title)
    {
        this.title = title;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}