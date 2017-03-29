using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void play()
    {
        Debug.Log("Huevo");
        Application.UnloadLevel(0);
        Application.LoadLevel(1);

    }
}
