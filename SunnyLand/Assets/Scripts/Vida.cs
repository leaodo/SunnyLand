using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Vida : MonoBehaviour
{
    public TMP_Text texto_vida;
    public ParticleSystem efeito;
    int vida = 0;
    private bool foiColetado = false;
    private void OnTriggerEnter2D(Collider2D outro)
    {
        if (foiColetado) return;
        if (outro.CompareTag("Player"))
        {
            
           foiColetado = true; 
            
            vida++;
            texto_vida.text = "Vida:" + vida.ToString();
            outro.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            Instantiate(efeito, transform.position, Quaternion.identity);
            Destroy(gameObject);
            
        }
    }
    
}
