using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dano : MonoBehaviour
{
    
    public ParticleSystem efeito;
    int vida = 0;
    public GameManager GameManager;
    private bool foiColetado = false;
    void OnTriggerEnter2D(Collider2D outro)
    {
        if (foiColetado) return;
        if (outro.CompareTag("Player"))
        {
            
           foiColetado = true;
           GameManager.RemoverVida(vida);

           
            Instantiate(efeito, transform.position, Quaternion.identity);
            Destroy(gameObject);
            
        }
    }
}
