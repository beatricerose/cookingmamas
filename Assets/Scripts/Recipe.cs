using UnityEngine;
using System.Collections;
using System; //This allows the IComparable Interface

public class Recipe
{
    public int flour;
    public int sugar;
    public int butter;
    public int chocolate;
    public int egg;

    public Recipe(int f, int s, int b, int c, int e)
    {
        flour = f;
        sugar = s;
        butter = b;
        chocolate = c;
        egg = e;
    }
}

