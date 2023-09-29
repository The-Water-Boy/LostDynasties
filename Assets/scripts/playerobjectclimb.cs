using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerobjectclimb : MonoBehaviour
{
    public GameObject playerscrip;
    bool playermovementlockcheck;
    bool playerdetected;

    
    bool shiftpressed;
    // Start is called before the first frame update
    void Start()
    {
      playermovementlockcheck = playerscrip.GetComponent<playerclimbinbetweenscript>();
    }

    // Update is called once per frame
    void Update()
    {

        /*if (Input.GetKey(KeyCode.LeftShift)){
                shiftpressed=true;
        }else{
                shiftpressed=false;
        }
        if(playerdetected == true && shiftpressed == true){
            playerscrip.GetComponent<rigidbodyplayermovement>().movementlock=true;
        }else{
            playerscrip.GetComponent<rigidbodyplayermovement>().movementlock=false;
        }*/

        /*if(playerdetected){
            print("cheese1");
            playerscrip.GetComponent<playerclimbinbetweenscript>().playerinrange=true;
        }else{
            playerscrip.GetComponent<playerclimbinbetweenscript>().playerinrange=false;
        }*/
    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Player") 
        {
            print("cheese");
            playerdetected=true;
            playerscrip.GetComponent<playerclimbinbetweenscript>().playerinrange=true;
        }
    }

    void OnTriggerExit(Collider other){
        playerdetected=false;
        playerscrip.GetComponent<playerclimbinbetweenscript>().playerinrange=false;
    }

}
