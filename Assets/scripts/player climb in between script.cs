using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerclimbinbetweenscript : MonoBehaviour
{
    public GameObject playerbody;
    bool shiftpressed;
    public bool playerinrange;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if(playerinrange){
        print("cheese2");

        }
        //if(playerinrange == true){print("true");}
        //if(playerinrange == false){print("false");}
        if (Input.GetKey(KeyCode.LeftShift)){
                shiftpressed=true;
        }else{
                shiftpressed=false;
        }
        if(playerinrange == true && shiftpressed == true){
            print("cheese3");
            playerbody.GetComponent<rigidbodyplayermovement>().movementlock=true;
        }else{
            playerbody.GetComponent<rigidbodyplayermovement>().movementlock=false;
        }
        
        
    }

}
