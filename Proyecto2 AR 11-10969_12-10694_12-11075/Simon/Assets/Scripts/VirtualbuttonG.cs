using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualbuttonG : MonoBehaviour, IVirtualButtonEventHandler
{
    public Player jugador;
    public Boton boton;
    public GameObject VBButton;
    private bool isPressed;
    private Double timer;
    private Double timeToWait;
    // Use this for initialization
    void Start()
    {
        timeToWait = 0.25; // In seconds.
        isPressed = false;
        VBButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        timer = Time.realtimeSinceStartup;
    }

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        if (!isPressed && Time.realtimeSinceStartup - timeToWait > timer)
        {
            jugador.GetComponent<Player>().nombreHit = boton.name;
            isPressed = true;
            boton.activar();
            Debug.Log("Huevo");
        }
        else
        {
            timer = Time.realtimeSinceStartup - timeToWait / 2;
            //jugador.GetComponent<Player>().nombreHit = null;
        }

    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        isPressed = false;
        timer = Time.realtimeSinceStartup;
        //jugador.GetComponent<Player>().boton = null;
        Debug.Log("COA");
    }
}
