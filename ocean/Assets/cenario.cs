using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cenario : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Time.deltaTime -> recebe o tempo exato de um frame pro outro
        //Vector2 --> x:-1, y:0
        transform.Translate(Vector2.left * Time.deltaTime);

        // caso a posição seja menor que -4, somamos +8 na posição de x
        if(transform.position.x < -4)
        {
            transform.position = new Vector2(
                transform.position.x +5,
                transform.position.y
            );
        }
    }
}
