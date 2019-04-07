
using System.Collections;

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gameplay : MonoBehaviour
{
   // public void GameOver()
   // {
    //    Debug.Log("Endgame");
    //}
    public static string cuttingboardS1 = "empty";    //These are the locations #1
    public static string cuttingboardS2 = "empty";    //Location #2
    public static string cuttingboardS3 = "empty";    //Location #3

    public static string grillS1 = "empty";
    public static string grillS2 = "empty";
    public static string grillS3 = "empty";

    public static int selectedSlot = 0;
    public static int selectedSandwich = 0;

    public KeyCode GiveFood;
    public static bool deleteFood = false;
    public static string currentMeat;
    public GameObject gameOverUI;
    void Update()
    {
        if(Input.GetKeyDown(GiveFood))
            {
            deleteFood = true;
            
        }
    }
    
} 

   