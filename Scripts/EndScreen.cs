using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    public void Restart(){
        SceneManager.LoadScene("Gameplay");
    }

    public void Exit(){
        SceneManager.LoadScene("Main Menu");
        
    }
}
