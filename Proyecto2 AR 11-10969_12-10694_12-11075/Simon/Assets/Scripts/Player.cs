using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Boton boton;
    public string nombreHit;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        nombreHit = null;
        /*
        if (Input.GetButtonDown("Fire1"))
        {
            ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Boton boton = hit.transform.GetComponent<Boton>();
                nombreHit = boton.name;
                boton.activar();
            }
        }
        */
    }
}

