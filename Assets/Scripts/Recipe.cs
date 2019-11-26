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
        flour = f;
        sugar = s;
        butter = b;
        chocolate = c;
    }
}

