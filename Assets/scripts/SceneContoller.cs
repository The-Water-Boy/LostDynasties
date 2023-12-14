using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneContoller : MonoBehaviour
{

   void Update()
   {
      if(Input.GetKey(KeyCode.R))
      {
         RestartLevel();
      }
   }
   public void PlayGame()
   {
        SceneManager.LoadScene(0);
   }

   public void QuitGame()
   {
    Application.Quit();
   }

   public void LoadMainMenu()
   {
      SceneManager.LoadScene(1);
   }

   public void RestartLevel()
   {
      SceneManager.LoadScene(0);
   }

}
