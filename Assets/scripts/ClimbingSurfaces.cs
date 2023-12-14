using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbingSurfaces : MonoBehaviour
{
    private bool PlayerIsDetected;
    public GameObject PlayerBodyMain;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerBody.GetComponent<playermovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerIsDetected && Input.GetKey(KeyCode.LeftShift))
        {
            Debug.Log("is true");
            PlayerBodyMain.GetComponent<playermovement>().movementLock = true;
            
        }

        if(!PlayerIsDetected)
        {
            Debug.Log("is false");
            PlayerBodyMain.GetComponent<playermovement>().movementLock = false;
        }

        if(!Input.GetKey(KeyCode.LeftShift))
        {
            Debug.Log("shift not pressed");
            PlayerBodyMain.GetComponent<playermovement>().movementLock = false;
        }

    }

    void OnTriggerEnter(Collider other)
    {
        PlayerIsDetected = true;
        if(other.gameObject.tag == "Player")
        {
            PlayerIsDetected = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        PlayerIsDetected = false;
    }
}
