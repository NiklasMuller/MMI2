using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ColliderBehave : MonoBehaviour
{
    // Start is called before the first frame update
    public bool hit = false; 
    public bool hitRitter = false;

    public GameObject drache;
    public GameObject mage;

    Animator dracheA;
    Animator mageA;

    GameObject shake;
 
    void Start()
    {
        dracheA = drache.GetComponent<Animator>();
        mageA = mage.GetComponent<Animator>();

        shake = GameObject.Find("Shake");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Fireball" && hit==true) {
           
           

            hit = false;
            Health health =  GameObject.Find("Drache").GetComponent<Health>();

            int hurt = Random.Range(1,3);
            if (health != null) {

                health.takeDamage(hurt);
                dracheA.SetTrigger("Hurt");
                GameObject.FindWithTag("Fireball").SetActive(false);

            }
            Debug.Log("Getroffen");


        }
        if (other.gameObject.tag == "attackBall" && hitRitter==true){


            hitRitter = false;


            Health health = GameObject.Find("Ritter").GetComponent<Health>();


            if(shake.GetComponent<Shaking>().defend==false){

               /* if (health.currentHealth == 100) health.takeDamage(15);
                else if (health.currentHealth == 85) health.takeDamage(15);

                else*/ if (health != null){

                    health.takeDamage(30);
                    mageA.SetTrigger("Hurt");
                    GameObject.FindWithTag("attackBall").SetActive(false);

                }

            }


        }



    }
}
