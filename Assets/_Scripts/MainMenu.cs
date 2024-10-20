using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame() //wird von Playbutton aufgerufen
    {
        SceneManager.LoadSceneAsync(1); //Lade Lvl1
    }
    public void QuitGame() //wird von Quitbutton aufgerufen
    {
        Application.Quit(); //Quit Game
    }
}
