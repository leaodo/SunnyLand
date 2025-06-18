using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tails : MonoBehaviour
{
    private string name = "Tails";
    private int vida = 5;
    private float velocidade = 100;
    private bool alive = true;
    private float gravidade = 10;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("vai filhão"+ name+ vida+ velocidade+ alive);
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = gravidade;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
