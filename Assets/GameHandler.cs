using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    Health health1;
    Health health2;

    bool flagDie1 = false;
    bool flagDie2 = false;


    Animator enemy;
    Animator player;

    public GameObject win;
    public GameObject gameOver;

    public GameObject newgame;

    public GameObject quit;

    public GameObject main;

    public GameObject attack;


    // Start is called before the first frame update
    void Start()
    {
        health1 = player1.GetComponent<Health>();
        health2 = player2.GetComponent<Health>();

        enemy = GameObject.Find("ChaDragon").GetComponent<Animator>();
        player = GameObject.Find("ChaWitch").GetComponent<Animator>();

    



    }

    // Update is called once per frame
    void Update()
    {
        if(health2.currentHealth<=0){

            attack.SetActive(false);
            Destroy(GameObject.Find("Attack2"));

            if (flagDie1==false){
                enemy.SetTrigger("Dead");
                flagDie1 = true;
                return;

            }
            win.SetActive(true);
            main.SetActive(true);
            quit.SetActive(true);
            newgame.SetActive(true);

        }
        else if (health1.currentHealth <= 0)
        {
            attack.SetActive(false);
            Destroy(GameObject.Find("attackDragon"));

            if (flagDie2 == false)
            {
                player.SetTrigger("Dead");
                flagDie2 = true;
                return;

            }
            gameOver.SetActive(true);
            main.SetActive(true);
            quit.SetActive(true);
            newgame.SetActive(true);

        }
    }

    public void startNew(){
        SceneManager.LoadScene("Game_Scene");
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void toMain(){
        SceneManager.LoadScene("StartScreen");
        Destroy(GameObject.Find("AudioSource"));

    }
}
