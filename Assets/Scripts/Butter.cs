using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Butter : MonoBehaviour
{
    Text text;
    public static int butterAmount;

    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = butterAmount.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        
    }
}
