using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu; //Pausemenu UI
    [SerializeField] GameObject pauseButton; //Pauseknopf
    public void PauseGame() //wird von Pauseknopf aufgerufen
    {
        pauseMenu.SetActive(true); //UI einblenden
        pauseButton.SetActive(false); //Knopf ausblenden
        Time.timeScale = 0; //Zeit pausieren
    }
    public void ResumeGame() //wird von Resumeknopf aufgerufen
    {
        pauseMenu.SetActive(false); //UI ausblenden
        pauseButton.SetActive(true); //Knopf einblenden
        Time.timeScale = 1; //Zeit weiterlaufen lassen
    }
    public void ReturnToMenu() //wird von Menuknopf aufgerufen
    {
        SceneManager.LoadSceneAsync(0); //Lade Menu
        Time.timeScale = 1; //Zeit weiterlaufen lassen
    }
    public void RestartLevel() //wird von Restartknopf aufgerufen
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex); //jetzige Szene neu laden
        Time.timeScale = 1; //Zeit weiterlaufen lassen
    }
    
}
