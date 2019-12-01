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
        StartCoroutine(WaitAnimate());
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

    IEnumerator WaitAnimate()
    {
        yield return new WaitForSeconds(60f);
    }
}
