using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    // Start is called before the first frame update

    public Text gameovertext;

    void Start()
    {
        //gameovertext = GetComponent<Text>(); //dont do it since script are in different object so cannot find the object
        HideText();
    }

    public void HideText()
    {
        gameovertext.enabled = false;
    }

    public void ShowText() 
    {
        gameovertext.enabled=true;
    
    }
}
