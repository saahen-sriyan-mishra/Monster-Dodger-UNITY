using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    //to access itself's object 
    //This variable is shared across all instances of the GameManager class.
    public static GameManager Instance;
    //singleton pattern that the class has a global point of access

    [SerializeField]
    private GameObject[] playerSelected;


    //stores actual data foe CharIndex, _ since its a field not a property
    private int _CharINDEX;
    public int CharIndex
    {
        //allows external code to read the value of _CharINDEX
        get { return _CharINDEX; }
        //It allows external code to set the value of _CharINDEX
        set { _CharINDEX = value; }
    }
    // Start is called before the first frame update

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        //only 1 copy of game manager
        else
        {
            Destroy(gameObject);
        }
    }

        // Which Player To select
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }
    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

    void OnLevelFinishedLoading (Scene sc, LoadSceneMode mode)
    {
        if(sc.name == "GamePlay")
        {
            Instantiate(playerSelected[CharIndex]);
        }

    }
        

}
