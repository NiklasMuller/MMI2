using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class attack : MonoBehaviour
{


    public bool flag;
    bool firstPlace = true;
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

    public GameObject coliderRitter;

    public bool wizardActive = false;
    public bool dragonActive = false;



    void Start()
    {
        anim = player.GetComponent<Animator>();
        InvokeRepeating("TaskOnClick", 8f, 8f);
        

    }

    // Update is called once per frame
    void Update()
    {
        step = speed * Time.deltaTime;
        if (flag == true)
        {

            if (firstPlace == true)
            {
                if(fireball!=null)fireball.transform.position = character.transform.position;
                firstPlace = false;
            }


            moveTo();

        }

    }

    void TaskOnClick()
    {
        anim.SetTrigger("Attack");
        if (wizardActive == true && dragonActive == true){
    
            coliderRitter.GetComponent<ColliderBehave>().hitRitter = true;

        if (flag == false) flag = true;
        else
        {
            flag = true;
            firstPlace = true;
        }
        }
    }

    void moveTo()
    {

        
            posEnemy = enemy.transform.position;
        if (fireball != null) posMe = fireball.transform.position; // Get position of object A
            posTravel = posEnemy - posMe;
            if (Vector3.Distance(posMe, posEnemy) > 1)
            {
            if (fireball != null) fireball.SetActive(true);
            if (fireball != null) fireball.transform.Translate(
                    (posTravel.normalized.x * step),
                    (posTravel.normalized.y * step),
                    (posTravel.normalized.z * step),
                    Space.World);
            }

        else
        {
           
            fireball.SetActive(false);
            flag = false;
            firstPlace = true;
        }
    }
}
