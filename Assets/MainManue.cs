using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainManue : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    public void PlayGame()
    {
        panel.SetActive(true);
    }

    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions_Scene");
    }

    public void startGame()
    {
        SceneManager.LoadScene("Game_Scene");
    }
}
