using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecipeManager : MonoBehaviour
{
    public static RecipeManager instance;

    private void Awake()
    {
        //cookieRecipe.Add(Ingredient.Butter, 2);
        //instance = this;
    }

    // Start is called before the first frame update --> can't call if not Singleton (all static)
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void FoodCollected(Collider item)
    {
        if (item.CompareTag("Peanut"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (item.CompareTag("Flour"))
        {
            Flour.flourAmount -= 1;
        }
        /*else if (item.CompareTag("Egg"))
        {
            myEgg++;
        }
        */
        else if (item.CompareTag("Sugar"))
        {
            Sugar.sugarAmount -= 1;
        }
        else if (item.CompareTag("Butter"))
        {
            Butter.butterAmount -= 1;
        }
        else if (item.CompareTag("Chocolate"))
        {
            Chocolate.chocolateAmount -= 1;
        }
        /*else if (item.CompareTag("Special"))
        {
           mySpecial++;
        }*/

        if (Flour.flourAmount == 0 && Sugar.sugarAmount == 0 && Butter.butterAmount == 0 && Chocolate.chocolateAmount == 0)
        {
            // run the animation, load next scene
            // make spoon clickable? ie. toggle the kinetic to make it clickable
            print("Works");
        }
        else if(Flour.flourAmount < 0 || Sugar.sugarAmount < 0 || Butter.butterAmount < 0 || Chocolate.chocolateAmount < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void SetRecipe(Recipe myRecipe)
    {
        Flour.flourAmount = myRecipe.flour;
        Sugar.sugarAmount = myRecipe.sugar;
        Butter.butterAmount = myRecipe.butter;
        Chocolate.chocolateAmount = myRecipe.chocolate;
    }
}
