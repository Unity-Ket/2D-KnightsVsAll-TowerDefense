using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    [SerializeField] int waitTime = 3;
    int currentSceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(WaitTime());
        }
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(waitTime);
        LoadNextScene();
    }

    public void loadMainmenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start Screen");
    }

    public void restartLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void loadLoseScreen()
    {
        SceneManager.LoadScene("Lose Screen");
    }

    public void loadOptionScreen()
    {
        SceneManager.LoadScene("Option Screen");
    }

    public void loadCreditScreen()
    {
        SceneManager.LoadScene("Credit Screen");
    }

    public void quitApp()
    {
        Application.Quit();
    }

    public void GlitchButton()
    {
        Application.OpenURL("https://www.glitchthegame.com");
    }

    public void CraftButton()
    {
        Application.OpenURL("https://craftpix.net");
    }
}
