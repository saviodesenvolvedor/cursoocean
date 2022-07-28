using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    // ACESSAR O RGB NO UNITY
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //DETECTAR A AÇÃO DO JOGADOR
        if(Input.GetButtonDown("Jump"))
        {
            Pular();
        }
    }

    void Pular()
    {
        print("Pular!");
        // add uma força
        rb.AddForce(130f * Vector2.up);
    }
}
