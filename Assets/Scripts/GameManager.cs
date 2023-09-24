using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("EscenaNoche"); 
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    void Start()
    {

    }

 
    void Update()
    {

    }
}
