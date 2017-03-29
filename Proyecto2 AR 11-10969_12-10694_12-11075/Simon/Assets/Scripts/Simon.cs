using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simon : MonoBehaviour {

    
    public List<Boton> botones = new List<Boton>();
    List<int> generados = new List<int>();
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
	}

    public List<int> generar()
    {
        generados.Add(UnityEngine.Random.Range(0, 4));
        return generados;
    }

    internal void simonMove(float time)
    {
        StartCoroutine(presionar(time));
    }

    IEnumerator presionar(float time)
    {
        for(int i = 0; i < generados.Count; i++)
        {
            
            yield return new WaitForSeconds(time);
            botones[generados[i]].activar();
        }
    }
}
