using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Button_Attack : NetworkBehaviour
{

    public bool flag;
     bool firstPlace=true;
    public Button butt1;
    public GameObject fireball;
    string monsterName;
     GameObject character;
     GameObject enemy;
    public float speed;
    float step;
    Vector3 posEnemy;
    Vector3 posMe;
    Vector3 posTravel;

    public GameObject[] monsterList;
    // Start is called before the first frame update
    void Start()
    {

        monsterName = GameObject.Find("Player(Clone)").GetComponent<PlayerAttributes>().playerMonster;
        character = GameObject.Find(monsterName);
        butt1.onClick.AddListener(TaskOnClick);
        monsterList = GameObject.FindGameObjectsWithTag("Monster");
        //toDO: Später auf weitere Monster anpassen 
        foreach (GameObject monster in monsterList)
        {
            if (monster.name != monsterName){
                enemy = monster;
                Debug.Log(enemy);
                Debug.Log(monsterName);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        step = speed * Time.deltaTime;
        if(flag==true){
            fireball.SetActive(true);
            if(firstPlace==true){
                fireball.transform.position = character.transform.position;
                firstPlace = false;
            }

            moveTo();
            
        } 

    }

    void TaskOnClick(){
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
