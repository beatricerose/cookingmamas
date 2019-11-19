using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static string prevScene;
    public ArrayList recipeSet;

    public void SetPrevScene(string name)
    {
        prevScene = name;
    }

    public string GetPrevScene()
    {
        return prevScene;
    }

    public void recipeCreate()
    {

        int[] cookie = { 1, 2, 3 , 4, 5, 6};
        int[] chocolateCake = { 1, 2, 3, 4, 5, 6 };
        int[] croissant = { 1, 2, 3, 4, 5, 6 };
        //int[] = { 1, 2, 3 , 4, 5, 6};
        recipeSet.Add(cookie);
        recipeSet.Add(chocolateCake);
        recipeSet.Add(croissant);
    }
}