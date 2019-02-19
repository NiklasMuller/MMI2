using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{

    private AudioSource audioS;
    private float volume = 1f;
    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

     void Start()
    {
        audioS = GetComponent<AudioSource>();
    }

    void Update()
    {
        audioS.volume = volume;
    }

    public void setVolume(float a){
        volume = a;
    }
}
