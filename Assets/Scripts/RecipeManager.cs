using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecipeManager : MonoBehaviour
{
    public static RecipeManager instance;
    public static Recipe cookie;
    public static Recipe cake;
    public static Recipe croissant;
    public static Recipe[] recipeList;

    private void Awake()
    {
        instance = this;
        cookie = new Recipe(3, 2, 1, 3, 3);
        cake = new Recipe(3, 2, 2, 5, 4);
        croissant = new Recipe(4, 1, 4, 2, 2);
        recipeList[0] = cookie;
        recipeList[1] = cake;
        recipeList[2] = croissant;
    }

    // Start is called before the first frame update --> can't call if not Singleton (all static)
    void Start()
    {
        //int index = SceneManager.GetActiveScene().buildIndex + 1;
        SetRecipe(recipeList[1]);
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
        else if (item.CompareTag("Egg"))
        {
            Egg.eggAmount -= 1;
        }
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

        if (Flour.flourAmount == 0 && Sugar.sugarAmount == 0 && Butter.butterAmount == 0 && Chocolate.chocolateAmount == 0 && Egg.eggAmount == 0)
        {
            // run the animation, load next scene
            //print("Works");
        }
        else if(Flour.flourAmount < 0 || Sugar.sugarAmount < 0 || Butter.butterAmount < 0 || Chocolate.chocolateAmount < 0 || Egg.eggAmount < 0)
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
        Egg.eggAmount = myRecipe.egg;
    }
}
