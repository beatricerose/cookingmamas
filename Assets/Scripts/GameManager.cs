using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System; //This allows the IComparable Interface


public class GameManager : MonoBehaviour
{
    public static string prevScene;
    private Recipe[] recipeList;

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
        // flour, sugar, butter, chocolate
        Recipe cookie = new Recipe(1, 2, 3, 4);
        Recipe cake = new Recipe(1, 2, 3, 4);
        Recipe bread = new Recipe(1, 2, 3, 4);
        recipeList[0] = cookie;
        recipeList[1] = cake;
        recipeList[2] = bread;
    }
}
