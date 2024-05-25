using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;


public class Home_RestartUI : MonoBehaviour
{
    public void restart()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void Home ()
    {
        SceneManager.LoadScene("MainMenu");
    }
   
  
}
