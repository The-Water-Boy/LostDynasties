using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidbodyplayermovement : MonoBehaviour
{
    [Header("Movement")]
    bool wpressed, apressed, dpressed, spressed, spacepressed;
    public bool movementlock, shiftpressed;
    Transform otherobject;
    float speed = 50.0f;
    Rigidbody player;
    int jumpcheck;
    int parkourcounter;
    public Transform playerparent;
    public Transform playerself;
    float Rotationspeed;
    public Transform orientation;
    Vector3 moveDirection;
    


    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
        player.freezeRotation=true;
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

    private void FixedUpdate(){
        
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
                player.AddForce(orientation.forward * -1 * speed * Time.fixedDeltaTime, ForceMode.Impulse);
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

}
