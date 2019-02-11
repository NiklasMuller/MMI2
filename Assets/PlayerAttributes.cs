using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerAttributes : NetworkBehaviour
{
    [SyncVar]
    public string pname = "player";

    [SyncVar]
    public Color playerColor = Color.white;

    // Start is called before the first frame update
    void Start()
    {
        /*
         * if(isLocalPlayer)
         *      GetComponent<button>().enabled = true;
         *      Irgendwie festlegen, dass der Button dem Spieler gehört und nur er damit attackieren kann? 
         *      Keine Ahnung ob man das braucht.
         */

        Renderer[] rends = GetComponentsInChildren<Renderer>();
        foreach (Renderer r in rends)
            // To-do: Nur den Text umfärben! Moment wird alles was zum Player-Objekt gehört eingefärbt!
            r.material.color = playerColor;
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponentInChildren<TextMesh>().text = pname;
        this.GetComponentInChildren<TextMesh>().transform.position = new Vector3(0, 0, 1050);
        Debug.Log(pname);
    }
}