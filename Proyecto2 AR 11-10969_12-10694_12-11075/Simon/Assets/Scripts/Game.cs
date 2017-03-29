using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour {

    public Player jugador;
    public Simon simon;
    public List<Boton> botones = new List<Boton>();
    public Text texto,score,over;
    int scores = 0;
    bool perdio = false;
    int contador = 0;
    int turno = 0;
    int cantidadTiles = 0;
    int playerMoves = 0;
    bool juega = false;
    List<int> simonsMoves;
    List<string> simonMovesN = new List<string>();
    // Use this for initialization
    void Start() {
        texto.GetComponent<Text>().text = "";
    }

    // Update is called once per frame
    void Update() {
        if (perdio && contador == 3)
        {
            texto.GetComponent<Text>().text = "";
            StartCoroutine(gameOver());
        }
        if (turno % 2 == 0 && !juega)
        {
            simonsMoves = simon.GetComponent<Simon>().generar();
            simonMovesN.Add(botones[simonsMoves[cantidadTiles]].gameObject.name);
            cantidadTiles++;
            juega = true;
        }
        if (turno % 2 == 0 && juega)
        {
            playerMoves = 0;
            perdio = false;
            simon.GetComponent<Simon>().simonMove(1f);
            turno++;
            juega = false;
        }
        else
        {
            if (playerMoves == cantidadTiles)
            {
                scores++;
                score.GetComponent<Text>().text = "Score = " + scores;
                playerMoves = 0;
                turno++;
            }
            if (jugador.GetComponent<Player>().nombreHit != null)
            {
                if (simonMovesN[playerMoves].Equals(jugador.GetComponent<Player>().nombreHit))
                {
                    playerMoves++;
                }
                else
                {
                    perdio = true;
                    if(contador < 3)
                    {
                        contador++;
                        texto.GetComponent<Text>().text += "X ";
                    }
                }
            }
        }
    }
    
    IEnumerator gameOver()
    {
        over.gameObject.SetActive(true);
        yield return new WaitForSeconds(4f);
        Application.LoadLevel(Application.loadedLevel);
    }
}
