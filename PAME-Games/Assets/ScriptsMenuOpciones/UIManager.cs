using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject optionsPanel;
    public GameObject settingsPanel;

    public void OptionsPanel()
    {
        Time.timeScale = 0;
        optionsPanel.SetActive(true);
    }

    public void Return()
    {
        Time.timeScale = 1;
        optionsPanel.SetActive(false);
    }

    public void AnotherOptions()
    {
        //SOUND / MUSIC / GRAPHICS 
        optionsPanel.SetActive(false);
        settingsPanel.SetActive(true);
    }

    public void GoOptionsPanel()
    {
        optionsPanel.SetActive(true);
        settingsPanel.SetActive(false);
    }

    public void GoMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
