using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushpullmech : MonoBehaviour
{
     public GameObject playerscript;
    public Transform body;
    public Transform player;
    int counter;
    bool playerdetected;
    // Start is called before the first frame update
    void Start()
    {
        counter= 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerscript.GetComponent<playerobjectinteraction>().epressed==false){
            body.parent = null;
            counter = 0;
            //print("epressed false");
        }
        if(playerdetected==true && playerscript.GetComponent<playerobjectinteraction>().epressed == true && counter==0){
            counter = 1;
            body.parent = player;
            //print("epressed true");
        }
        
    
    }

    void OnCollisionEnter(Collision other){
        playerdetected=true;
    }

    void OnCollisionExit(Collision other){
        playerdetected=false;
    }
}
