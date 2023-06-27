using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public static float input;

    public void Easy(){
        SceneManager.LoadScene("Gameplay");
        input = 5f;
    }

    public void Medium(){
        SceneManager.LoadScene("Gameplay");
        input = 10f;
    }

    public void Hard(){
        SceneManager.LoadScene("Gameplay");
        input = 20f;
    }

    public void Impossible(){
        SceneManager.LoadScene("Gameplay");
        input = 50f;
    }

    public static float getInput(){
        return input;
    }
}
