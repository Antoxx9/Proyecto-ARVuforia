using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour {

    AudioSource audio;
    Coroutine courutine;
    Color originalColor;
    bool animando;
    public string nombre;
    // Use this for initialization
	void Start () {
        originalColor = gameObject.GetComponent<Renderer>().material.color;
        nombre = gameObject.name;
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
    }

    internal void activar()
    {
        if (animando)
        {
            return;
        }
        if(courutine != null)
        {
            StopCoroutine(courutine);
        }
        audio.Play();
        Invoke("StopAudio", 0.3f);
        courutine = StartCoroutine(cambiarColor(transform.GetComponent<Renderer>().material));
    }

    void StopAudio()
    {
        audio.Stop();
    }

    private IEnumerator cambiarColor(Material material)
    {
        animando = true;
        LeanTween.cancel(gameObject);
        LeanTween.moveLocalY(gameObject, -58.5f, 0.2f);
        if (gameObject.name == "Verde")
        {
            LeanTween.color(gameObject, Color.green, 0.5f).setEase(LeanTweenType.easeInOutSine);
        }
        else if (gameObject.name == "Rojo")
        {
            LeanTween.color(gameObject, Color.red, 0.5f).setEase(LeanTweenType.easeInOutSine);
        }
        else if (gameObject.name == "Azul")
        {
            LeanTween.color(gameObject, new Color(0f,0.345f,1f,1f), 0.5f).setEase(LeanTweenType.easeInOutSine);
        }
        else if (gameObject.name == "Amarillo")
        {
            LeanTween.color(gameObject, Color.yellow, 0.5f).setEase(LeanTweenType.easeInOutSine);
        }
        yield return new WaitForSeconds(0.5f);
        LeanTween.moveLocalY(gameObject, -56.5f, 0.2f);
        LeanTween.color(gameObject, originalColor, 0.5f).setEase(LeanTweenType.easeInOutSine);
        animando = false;
    }
}
