using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Ingredient
{
    Flour,
    Sugar,
    Butter,
    Egg
}

// Look into scriptable object

public class RecipeManager : MonoBehaviour
{
    public static RecipeManager instance;

    //Dictionary<Ingredient, int> cookieRecipe = new Dictionary<Ingredient, int>();

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
            // death scene --> YOU KILLED SOMEONE
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
            // RESET SCENE
        }
    }

    public void setRecipe(int[] recipe)
    {
        Flour.flourAmount = recipe[0];
        Sugar.sugarAmount = recipe[1];
        Butter.butterAmount = recipe[2];
        //totalEgg = recipe[3];
        Chocolate.chocolateAmount = recipe[3];
        //totalSpecial = recipe[5];
    }
}
