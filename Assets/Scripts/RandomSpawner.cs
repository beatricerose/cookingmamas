using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System;

public class RandomSpawner : MonoBehaviour
{
   // public GameObject food;
    public List<GameObject> list;
    bool startnext = true;
    private int spawnWidth = 7;
    // Start is called before the first frame update
    private int randomNum;

    void Start()
    {
// System.Random rng = new System.Random();
    }
    IEnumerator WaitToDrop()
    {
        startnext = false;
        //can change the time of that
        yield return new WaitForSeconds(2f);
        
        int length = list.Count;
        int index = Random.Range(0, length);
        GameObject sprite = list[index];

        
        Vector3 spawnPosition = transform.position;
        int xpos = Random.Range(-spawnWidth, spawnWidth);
        print(xpos);
        spawnPosition += new Vector3(xpos, 0, 0);
        
        GameObject copyfood = Instantiate(sprite, spawnPosition, Quaternion.identity);
        
        

        startnext = true;
    }
    

    // Update is called once per frame
    void Update()
    {
        if (startnext)
        {
            StartCoroutine(WaitToDrop());
        }
    }
}
