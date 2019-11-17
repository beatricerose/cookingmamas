using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spoon : MonoBehaviour
{
    bool turn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
      

        
            turn = true;
            if (turn == true)
            {
                Vector3 rotation = new Vector3(0, 360, 0);
                transform.Rotate(rotation);
            }
            turn = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
}
