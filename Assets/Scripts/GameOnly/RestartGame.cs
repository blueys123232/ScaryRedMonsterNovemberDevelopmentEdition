using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{

    public GameObject gameoverPanel;
    
    public void Restart()
   
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadMainMenu()
    {



        SceneManager.LoadScene("Main Menu"); // Replace "MainMenu" with the actual name of your main menu scene


    }

    public void QuitGame()
    {


        Application.Quit(); // Quit the application
      
    }
   
}
