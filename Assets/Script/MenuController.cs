using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
   public void PlayGame()
   {
        SceneManager.LoadScene("Game");
   }
   public void HowTo()
   {
        SceneManager.LoadScene("How To Play");
   }
   public void MainMenu()
   {
        SceneManager.LoadScene("Main Menu");
   }
   public void Quit()
   {
        Application.Quit();
   }
}
