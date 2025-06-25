using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PowerUP : MonoBehaviour
{
   
    public ParticleSystem efeito;
    int pontos = 0;
    public PlayerMovement PlayerMovement;
    public GameManager GameManager;
   private bool foiColetado = false;
    void OnTriggerEnter2D(Collider2D outroObjeto)
    {
        if (foiColetado) return;
        if (outroObjeto.CompareTag("Player"))
        {
            
           foiColetado = true;
            GameManager.AdicionarPontos(pontos);
            PlayerMovement.runSpeed = 50f;          
            Instantiate(efeito, transform.position, Quaternion.identity);
            Destroy(gameObject);
            
        }
    }

}
