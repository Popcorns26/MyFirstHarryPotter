using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SuccessCheck : MonoBehaviour
{
    InputActions inputs;

    private void Awake()
    {
        inputs = new InputActions();
        inputs.Flute.Flute1.performed+= context => SendMessage();
    }

    private void SendMessage()
    {
        Debug.Log("Flute 1");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Ron");
    }
}
