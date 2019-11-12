using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject food;
    public List<GameObject> list;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    IEnumerator WaitToDrop()
    {
        //can change the time of that
        yield return new WaitForSeconds(.2f);
        
        int length = list.Count;
        int index = Random.Range(0, length);
        GameObject sprite = list[index];

        //create a screen positioin?
        Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(600, Screen.height), Camera.main.farClipPlane / 2));
        //gonna need to get the position is it just the top of the screen?
        //can create a void bar on the top of the screen and put it there?
        GameObject copyfood = Instantiate(sprite, screenPosition, Quaternion.identity);
        Rigidbody2D rb2d = copyfood.GetComponent<Rigidbody2D>();

        rb2d.velocity = new Vector2(1, 1) * 5;

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(WaitToDrop());
    }
}
