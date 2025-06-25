using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int pontos;
    public TMP_Text pontosText;
    int vida;
    public TMP_Text vidaText;
    void Start()
    {
        pontos = 0;
        vida = 0;
    }
    public void AdicionarPontos(int valor)
    {
        pontos ++;
        pontosText.text = "pontos: " + pontos.ToString();
    }
    public void AdicionarVida(int valorv)
    {
        if (vida < 5)
        {
            vida++;
            vidaText.text = "vida: " + vida.ToString();
        }
        else
        {
            Debug.Log("Vida Cheia!");
        }
        
    }
    public void RemoverVida(int valord)
    {
        vida--;
        vidaText.text = "vida: " + vida.ToString();
        if(vida <= 0)
        {
            Debug.Log("Game Over!");
        }
    }

}
