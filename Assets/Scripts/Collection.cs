using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collection : MonoBehaviour
{
    int speed = 15;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(-Vector3.left * speed * Time.deltaTime);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        RecipeManager.FoodCollected(other);
        Destroy(other.gameObject);
    }
}
