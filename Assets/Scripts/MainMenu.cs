using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        int char_selection = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name); 
        
        GameManager.Instance.CharIndex = char_selection;
        SceneManager.LoadScene("GamePlay");
    }

        
}
