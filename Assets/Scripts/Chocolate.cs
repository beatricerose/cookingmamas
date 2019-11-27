using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chocolate : MonoBehaviour
{
    Text text;
    public static int chocolateAmount;

    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = chocolateAmount.ToString();
    }
}
