﻿using System.Collections;
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

    private int totalFlour;
    private int totalSugar;
    private int totalButter;
    private int totalEgg;
    private int totalChocolate;
    private int totalSpecial;
    private int myFlour = 0;
    private int mySugar = 0;
    private int myButter = 0;
    private int myEgg = 0;
    private int myChocolate = 0;
    private int mySpecial;

    Dictionary<Ingredient, int> cookieRecipe = new Dictionary<Ingredient, int>();

    private void Awake()
    {
        cookieRecipe.Add(Ingredient.Butter, 2);
        instance = this;
    }

    // Start is called before the first frame update --> can't call if not Singleton (all static)
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FoodCollected(GameObject item)
    {
        if (item.CompareTag("Peanut"))
        {
            // death scene --> YOU KILLED SOMEONE
        }
        else if (item.CompareTag("Flour"))
        {
            myFlour++;
        }
        else if (item.CompareTag("Egg"))
        {
            myEgg++;
        }
        else if (item.CompareTag("Sugar"))
        {
            mySugar++;
        }
        else if (item.CompareTag("Butter"))
        {
            myButter++;
        }
        else if (item.CompareTag("Chocolate"))
        {
            myChocolate++;
        }
        else if (item.CompareTag("Special"))
        {
            mySpecial++;
        }

        if (myFlour >= totalFlour && mySugar >= totalSugar && myEgg >= totalEgg && myButter >= totalButter && myChocolate >= totalChocolate)
        {
            // run the animation, load next scene
            // make spoon clickable? ie. toggle the kinetic to make it clickable 
        }
    }

    public void setRecipe(int[] recipe)
    {
        totalFlour = recipe[0];
        totalSugar = recipe[1];
        totalButter = recipe[2];
        totalEgg = recipe[3];
        totalChocolate = recipe[4];
        totalSpecial = recipe[5];
    }
}
