using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMAnager : MonoBehaviour
{


    public static MenuMAnager MenuManagerInstance;
    public bool GameState;
    public GameObject menuElement;


    // Start is called before the first frame update
    void Start()
    {
        GameState = false;
        MenuManagerInstance = this;
    }

    void Update()
    {

    }

    public void StartTheGame()
    {
        GameState = true;
        menuElement.SetActive(false);

    }

}
