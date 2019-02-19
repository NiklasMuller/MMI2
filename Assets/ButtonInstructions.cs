using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonInstructions : MonoBehaviour
{
    // Start is called before the first frame update
    public void loadStart(){
        Destroy(GameObject.Find("AudioSource"));
        SceneManager.LoadScene("StartScreen");
    }
}
