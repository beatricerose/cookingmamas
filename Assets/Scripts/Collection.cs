using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collection : MonoBehaviour
{
    int speed = 15;
    public GameObject batterPrefab;


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

        if (RecipeManager.recipeDone == true)
        {
            Vector3 target = transform.position;
            target.x += 1f;
            target.y -= 1f;

            Instantiate(batterPrefab, target, Quaternion.identity);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        
        if (!other.CompareTag("Table") && !other.CompareTag("Spoon"))
        {
            RecipeManager.FoodCollected(other);
            Destroy(other.gameObject);
        }
    }
}
