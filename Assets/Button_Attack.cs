using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Button_Attack : MonoBehaviour
{

    public bool flag;
     bool firstPlace=true;
    public Button butt1;
    public GameObject fireball;
    public GameObject character;
    public GameObject enemy;
    public float speed;
    float step;
    Vector3 posEnemy;
    Vector3 posMe;
    Vector3 posTravel;

    public GameObject player;
    Animator anim;

    public Collider coliderDrache;

    void Start()
    {
        butt1.onClick.AddListener(TaskOnClick);
        anim=player.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        step = speed * Time.deltaTime;
        if(flag==true){


            if (firstPlace==true){
                fireball.transform.position = character.transform.position;
                firstPlace = false;
            }

           
            moveTo();

        } 

    }

    void TaskOnClick(){
        anim.SetTrigger("Attack");
        coliderDrache.GetComponent<ColliderBehave>().hit = true;
        fireball.SetActive(true);
        if (flag == false) flag = true;
        else{
            flag = true;
            firstPlace = true;
        }
    }

    void moveTo(){
        posEnemy = enemy.transform.position;
        posMe = fireball.transform.position; // Get position of object A
        posTravel = posEnemy - posMe;
        if (Vector3.Distance(posMe, posEnemy) > 1)
        {
            fireball.transform.Translate(
                (posTravel.normalized.x * step),
                (posTravel.normalized.y * step),
                (posTravel.normalized.z * step),
                Space.World);
        }
        else
        {
           
            flag = false;
            firstPlace = true;
        }
    }
}
