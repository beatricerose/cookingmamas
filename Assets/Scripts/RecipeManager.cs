using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecipeManager : MonoBehaviour
{
    public static RecipeManager instance;
    public static Recipe cookie = new Recipe(3, 2, 1, 3, 2);
    public static Recipe cake = new Recipe(3, 2, 2, 5, 2);
    public static Recipe brownie = new Recipe(3, 2, 1, 5, 2);
    public static Recipe donut = new Recipe(3, 3, 3, 1, 2);
    public static Recipe macaron = new Recipe(4, 3, 3, 2, 6);
    public static Recipe[] recipeList = { cookie, cake, brownie, donut, macaron };
    private static string[] cookingSceneList = { "CookieScene", "CakeScene", "BrownieScene", "DonutScene", "MacaronScene"};
    public static bool recipeDone;
    

    private void Awake()
    {
        

        instance = this;
        recipeDone = false;
        int index = 0;
        for (int i = 0; i < cookingSceneList.Length; i++)
        {
            if (cookingSceneList[i].Equals(SceneManager.GetActiveScene().name))
            {
                index = i;
            }
        }
        SetRecipe(recipeList[index]);
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
            SceneManager.LoadScene("DeathScene");
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
           
            recipeDone = true;
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
