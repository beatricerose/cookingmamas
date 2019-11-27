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
}
