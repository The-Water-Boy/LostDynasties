using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneContoller : MonoBehaviour
{
   public void PlayGame()
   {
        SceneManager.LoadScene(0);
   }

   public void QuitGame()
   {
    Application.Quit();
   }
}