using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerobjectinteraction : MonoBehaviour
{   
    public bool epressed = false;
    private bool AllowPushing;
    public int ItemCounter;

    // Start is called before the first frame update
    void Start()
    {
        ItemCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(AllowPushing==true){
            //interactions();
        }
        interactions();
        if(ItemCounter == 4){
            Debug.Log("win");
        }
    }

    public void interactions(){
        if(Input.GetKey(KeyCode.E)){
            epressed=true;
        }else{
            epressed=false;
        }
    }

    void OnCollisionEnter(Collision other){
        if (other.gameObject.tag == "pushable") 
        {
            AllowPushing=true;
        }
    }

    void OnCollisionExit(Collision other){
        AllowPushing=false;
    }
}
