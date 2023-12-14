using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    private Animator playerAnimations;

    // Start is called before the first frame update
    void Start()
    {
        playerAnimations = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.A)){
            Debug.Log("is walking");
            playerAnimations.SetBool("walking", true);
        }else{
            playerAnimations.SetBool("walking", false);
        }

        if(Input.GetKey(KeyCode.S)){
            Debug.Log("walkbackwards");
            playerAnimations.SetBool("walkbackward", true);
            playerAnimations.SetBool("walking", false);
        }else{
            playerAnimations.SetBool("walkbackward", false);
        }

        if(Input.GetKey(KeyCode.Space)){
            Debug.Log("walkbackwards");
            playerAnimations.SetBool("jump", true);
            
        }else{
            playerAnimations.SetBool("jump", false);
        }

        if(Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.A) ){
            playerAnimations.SetBool("run", true);
        }else{playerAnimations.SetBool("run", false);}

    }
}
