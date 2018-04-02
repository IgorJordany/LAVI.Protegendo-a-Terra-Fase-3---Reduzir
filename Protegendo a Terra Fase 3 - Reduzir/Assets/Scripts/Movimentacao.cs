using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{

    private float VelocidadeDeMovimento = 10;
    private float VelocidadeDeRotacao = 120;

    // Update is called once per frame
    void Update()
    {

        float Horizontal = Input.GetAxis("Horizontal") * VelocidadeDeRotacao * Time.deltaTime;
        transform.Rotate(0, Horizontal, 0);
        float Vertical = Input.GetAxis("Vertical") * VelocidadeDeMovimento * Time.deltaTime;
        transform.Translate(0, 0, Vertical);
    }
}