using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personagem : MonoBehaviour
{
    Rigidbody2D fisica;
    private float velocidade = 3f;
    private void Awake()
    {
        this.fisica = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Debug.Log("Clicou");
            this.Impulsionar();
        }
    }
    void Impulsionar()
    {
        this.fisica.AddForce(Vector2.up * velocidade, ForceMode2D.Impulse);
    }
}
