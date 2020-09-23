using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSC : MonoBehaviour
{

    public int languageMenu = 0;
    public GameObject[] panels;

    private void Update()
    {
        for (int i = 0; i < panels.Length; i++)
        {
            if (i == languageMenu)
                panels[i].active = true;
            else
                panels[i].active = false;
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ConinueGame()
    {

    }

    public void LanguageUpdate(int language)
    {
        languageMenu = language;
    }


    public void ExitGame()
    {
        Application.Quit();
    }
}
