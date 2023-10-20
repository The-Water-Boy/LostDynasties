using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    [Header("Movement")]
    //bool wpressed, apressed, dpressed, spressed, spacepressed;
    public bool MovementLock, ShiftPressed;
    //Transform otherobject;
    float speed = 90.0f;
    Rigidbody player;
    int jumpcheck;
    //int parkourcounter;
    //public Transform playerparent;
    public Transform PlayerGraphics;
    //float Rotationspeed;
    public Transform Orientation;
    //Vector3 moveDirection;
    private NewPlayerControls newPlayerControls;

    private void Start()
    {
        player = GetComponent<Rigidbody>();
        newPlayerControls = new NewPlayerControls();
        newPlayerControls.Enable();
        newPlayerControls.Player.Movement.performed += Movement_performed;
        newPlayerControls.Player.Jump.performed += Jump_performed;
    }

    void Update()
    {  
        //rotate player
        //moveDirection = playerparent.position - new Vector3(transform.position.x,playerparent.position.y,transform.position.z);
        //Orientation.forward = moveDirection.normalized;
        //float horizontalinput = Input.GetAxis("Horizontal");
        //float Verticalinput = Input.GetAxis("Vertical");
        //Vector3 forceDirection = Orientation.forward*Verticalinput + Orientation.right*horizontalinput;
    }

    private void FixedUpdate()
    {
        //Debug.Log(Orientation.rotation.y);

        this.transform.rotation = Quaternion.Euler(0,Orientation.rotation.y*100,0);// sycronises player rotation to the camera so player is always facing forward

        Vector2 inputVector = newPlayerControls.Player.Movement.ReadValue<Vector2>();
        
        if(inputVector.x > 0)
        {
            player.AddForce(Orientation.right * speed * Time.fixedDeltaTime, ForceMode.Impulse);

        }else if(inputVector.x < 0)
        {
            player.AddForce(Orientation.right *-1* speed * Time.fixedDeltaTime, ForceMode.Impulse);
        }

        if(inputVector.y > 0)
        {
            player.AddForce(Orientation.forward * speed * Time.fixedDeltaTime, ForceMode.Impulse);

        }else if(inputVector.y < 0)
        {
            player.AddForce(Orientation.forward *-1* speed * Time.fixedDeltaTime, ForceMode.Impulse);
        }
         
    }

    private void Jump_performed(InputAction.CallbackContext context)
    {
        if(context.performed && jumpcheck == 0)
        {
                player.AddForce(Vector3.up * 50, ForceMode.Impulse);
                jumpcheck++;
        }
    }

    private void Movement_performed(InputAction.CallbackContext context)
    {
        Vector2 inputVector = newPlayerControls.Player.Movement.ReadValue<Vector2>();
         
    }

    void OnCollisionEnter(Collision other)
    {
        jumpcheck = 0;
    }

/*
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
        jumpcheck = 0;
        parkourcounter = 0;
    }

    // Update is called once per frame
    void Update()
    {  
        //rotate player
        float horizontalinput = Input.GetAxis("Horizontal");
        float Verticalinput = Input.GetAxis("Vertical");
        Parkour();
    }

    private void FixedUpdate()
    {
        this.transform.rotation= Quaternion.Euler(0,orientation.rotation.y*100,0);

            if (apressed && movementlock == false)
            {
                player.AddForce(orientation.right * -1 * speed * Time.fixedDeltaTime, ForceMode.Impulse);
            }
            if (dpressed && movementlock == false)
            {
                player.AddForce(orientation.right * speed * Time.fixedDeltaTime, ForceMode.Impulse);
            }
            if (wpressed && movementlock == false)
            {
                player.AddForce(orientation.forward * speed * Time.fixedDeltaTime, ForceMode.Impulse);
            }
            if (spacepressed && movementlock == false && jumpcheck == 0)
            {
                player.AddForce(Vector3.up * speed* 10 * Time.fixedDeltaTime, ForceMode.Impulse);
                jumpcheck++;
                parkourcounter++;
            }
            if (spressed && movementlock == false)
            {
                player.AddForce(playerparent.forward * -1 * speed * Time.fixedDeltaTime, ForceMode.Impulse);
            }
            if(wpressed && movementlock==true){
                player.AddForce(Vector3.up * speed * Time.fixedDeltaTime, ForceMode.Impulse);
            }

        #region
            if (Input.GetKey(KeyCode.W))
            {
                wpressed = true;
            }
            else
            {
                wpressed = false;
            }
            if (Input.GetKey(KeyCode.S))
            {
                spressed = true;
            }
            else
            {
                spressed = false;
            }
            if (Input.GetKey(KeyCode.A))
            {
                apressed = true;
            }
            else
            {
                apressed = false;
            }
            if (Input.GetKey(KeyCode.D))
            {
                dpressed = true;
            }
            else
            {
                dpressed = false;
            }
            if (Input.GetKey(KeyCode.Space))
            {
                spacepressed = true;
            }
            else
            {
                spacepressed = false;
            }
            #endregion  
    }

    void OnCollisionEnter(Collision other){
        jumpcheck = 0;
        transform.Rotate(0f,0f,0f,Space.Self);
    }
    void Parkour(){
        if( jumpcheck == 1 && Input.GetKey(KeyCode.Q) == true ){
            print("park");
            this.transform.Rotate(90f * Time.deltaTime * 30,0f,0f,Space.Self);
            //this.transform.Rotate(180f,0f,0f,Space.Self);
            //this.transform.Rotate(270f,0f,0f,Space.Self);
            //this.transform.Rotate(360f,0f,0f,Space.Self); && parkourcounter >= 1
            parkourcounter = 0;
            positonreset();
        }        
    }

    void positonreset(){
        if(jumpcheck == 0){
            transform.Rotate(0f,0f,0f,Space.Self);
        }
    }
*/
}
