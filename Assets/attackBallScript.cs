using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackBallScript : MonoBehaviour
{

    public GameObject attackBall;
    public GameObject player;
    float step;
    public float speed;

    Vector3 posEnemy;
    Vector3 posMe;
    Vector3 posTravel;

    // Update is called once per frame
    void Update()
    {
        step = speed * Time.deltaTime;
        shoot();
       
    }

    void shoot(){
        posEnemy = player.transform.position;
        posMe = attackBall.transform.position; // Get position of object A
        posTravel = posEnemy - posMe;
        if (Vector3.Distance(posMe, posEnemy) > 1)
        {
            attackBall.transform.Translate(
                (posTravel.normalized.x * step),
                (posTravel.normalized.y * step),
                (posTravel.normalized.z * step),
                Space.World);
        }

    }
}
