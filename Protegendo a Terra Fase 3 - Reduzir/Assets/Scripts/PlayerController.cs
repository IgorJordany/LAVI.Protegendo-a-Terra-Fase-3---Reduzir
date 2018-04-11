using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    //private float VelocidadeDeMovimento = 10;
    public Joystick joystick;
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        joystick = FindObjectOfType<Joystick>();
        //rb.velocity = new Vector3(- (joystick.Horizontal * 20f), 0, -(joystick.Vertical * 20f));
        rb.transform.Translate(joystick.Horizontal, 0, joystick.Vertical);
        /*
        float Horizontal = Input.GetAxis("Horizontal") * VelocidadeDeMovimento * Time.deltaTime;
        transform.Translate(Horizontal, 0, 0);
        float Vertical = Input.GetAxis("Vertical") * VelocidadeDeMovimento * Time.deltaTime;
        transform.Translate(0, 0, Vertical);
        */
    }
}