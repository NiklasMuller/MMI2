using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonJoinBehaviour : MonoBehaviour
{
    public Button join;
    public GameObject text;
    GameObject alert;
    // Start is called before the first frame update
    void Start()
    {
        join.interactable = false;
        alert = GameObject.Find("Alert");

     
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("MonsterName").GetComponent<Text>().text.Equals("")) 
        {
            alert.GetComponent<Text>().text = "Please scan your card!";

        }
        else
        {

            join.interactable = true;
            alert.GetComponent<Text>().text = "";

        }
    }

   
}
