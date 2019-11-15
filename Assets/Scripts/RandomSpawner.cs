using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
   // public GameObject food;
    public List<GameObject> list;
    bool startnext = true;
    public float spawnWidth = 1;
    // Start is called before the first frame update
    
    void Start()
    {
        
    }
    IEnumerator WaitToDrop()
    {
        startnext = false;
        //can change the time of that
        yield return new WaitForSeconds(2f);
        
        int length = list.Count;
        int index = Random.Range(0, length);
        GameObject sprite = list[index];

        //do not need to respect the cmaera's position
        //look at asteroid spawner from the first lab to see how this works :) 
        //Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(600, Screen.height), Camera.main.farClipPlane / 2));
        Vector3 spawnPosition = transform.position;
        //gonna need to get the position is it just the top of the screen?
        //can create a void bar on the top of the screen and put it there?
        //GameObject copyfood = Instantiate(sprite, screenPosition, Quaternion.identity);
        //spawnPosition += new Vector3(Random.Range(-spawnWidth, spawnWidth), 0, 0);
        //spawnPosition += new Vector3(Random.Range(-Screen.width, Screen.width), 0, 0);
        spawnPosition += new Vector3(Random.Range(-spawnWidth, spawnWidth), 0, 0);
        GameObject copyfood = Instantiate(sprite, spawnPosition, Quaternion.identity);
        Rigidbody rb2d = copyfood.GetComponent<Rigidbody>();

        rb2d.velocity = new Vector3(1, 1,1) * 5;
        //destory(copyfood);

        startnext = true;
    }
    //void destory(GameObject food)
    //{
        //if (rb2d.position.y < 0){
           // destoryObject(food); 
       // }    //}
    //figure out why it is swp

    // Update is called once per frame
    void Update()
    {
        //write a small timer that exists here
        //start the next coroutine when the first one finishes
        if (startnext)
        {
            StartCoroutine(WaitToDrop());
        }
    }
}
