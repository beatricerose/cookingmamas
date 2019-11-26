using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void sendRecipe()
    {
        int sceneIndex = SceneManager.getActiveScene().buildIndex;
        RecipeManager.setRecipe(recipeSet.get(sceneIndex + 1));
    }

    public void recipeCreate()
    {

        int[] cookie = { 1, 2, 3 , 4};
        int[] chocolateCake = { 1, 2, 3, 4};
        int[] croissant = { 1, 2, 3, 4};
        //int[] = { 1, 2, 3 , 4, 5, 6};
        recipeSet.Add(cookie);
        recipeSet.Add(chocolateCake);
        recipeSet.Add(croissant);
    }
}