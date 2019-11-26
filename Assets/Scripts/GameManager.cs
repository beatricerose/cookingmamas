using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System; //This allows the IComparable Interface


public class GameManager : MonoBehaviour
{
    public static string prevScene;
    private List<Recipe> recipeList;

    public void SetPrevScene(string name)
    {
        prevScene = name;
    }

    public string GetPrevScene()
    {
        return prevScene;
    }

    public void SendRecipe()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        RecipeManager.SetRecipe(recipeList.Item(sceneIndex));
    }

    public void CreateSet()
    {
        Recipe cookie = new Recipe(1, 2, 3, 4);
        Recipe cake = new Recipe(1, 2, 3, 4);
        Recipe bread = new Recipe(1, 2, 3, 4);
        recipeList.Add(cookie);
        recipeList.Add(cake);
        recipeList.Add(bread);
    }
}