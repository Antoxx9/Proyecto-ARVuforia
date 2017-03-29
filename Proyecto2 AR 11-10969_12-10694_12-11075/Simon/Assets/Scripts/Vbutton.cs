using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Vbutton : MonoBehaviour {

    public Boton boton;
	// Use this for initialization
	void Start () {
		
	}
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log(vb);
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("Holii");
    }
}
