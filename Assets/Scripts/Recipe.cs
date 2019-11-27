using UnityEngine;
using System.Collections;
using System; //This allows the IComparable Interface

public class Recipe
{
    public int flour;
    public int sugar;
    public int butter;
    public int chocolate;

    public Recipe(int f, int s, int b, int c)
    {
        Flour.flourAmount = f;
        Sugar.sugarAmount = s;
        Butter.butterAmount = b;
        Chocolate.chocolateAmount = c;
    }
}

