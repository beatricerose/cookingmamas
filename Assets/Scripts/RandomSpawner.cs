using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
   // public GameObject food;
    public List<GameObject> list;
    bool startnext = true;
    public float spawnWidth = 10;
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

        
        Vector3 spawnPosition = transform.position;
        spawnPosition += new Vector3(Random.Range(-spawnWidth, spawnWidth), 0, 0);
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
