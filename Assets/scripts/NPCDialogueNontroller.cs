using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPCDialogueNontroller : MonoBehaviour
{
    [SerializeField] private TMP_Text TextBox;
    //[SerializeField] private string[] sentences;
    public string[] sentences;
    private int ArrayIndexCheck; 
    // Start is called before the first frame update
    void Start()
    {
        ArrayIndexCheck = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        TextBox.text = sentences[ArrayIndexCheck];
        Debug.Log("colliding");
        
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("crashing");
    }
}
