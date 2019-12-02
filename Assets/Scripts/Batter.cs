using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batter : MonoBehaviour
{
    MeshRenderer myRenderer;
    private void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        myRenderer.enabled = false;
    }

    void Update()
    {
        if (RecipeManager.recipeDone == true)
        {
            myRenderer.enabled = true;
        }
    }
}
