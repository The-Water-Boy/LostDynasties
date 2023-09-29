using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerobjectinteraction : MonoBehaviour
{
    public bool epressed = false;
    bool allowpushing;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(allowpushing==true){
            //interactions();
        }
        interactions();
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
            allowpushing=true;
        }
    }

    void OnCollisionExit(Collision other){
        allowpushing=false;
    }
}
