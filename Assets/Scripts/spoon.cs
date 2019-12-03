using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spoon : MonoBehaviour
{
    Collider myCollider;
    

    private Animator anim;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        myCollider = GetComponent<Collider>();
        myCollider.enabled = false;
    }

    private void Update()
    {
        if (RecipeManager.recipeDone == true)
        {
            myCollider.enabled = true;
        }
    }

    void OnMouseUp()
    {

        anim.SetTrigger("Active");
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

    
}
