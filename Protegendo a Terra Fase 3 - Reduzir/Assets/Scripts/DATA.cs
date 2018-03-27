using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DATA : MonoBehaviour {
    public GameObject[] Datas;
    public static int PersonagemAInstanciar;

    private void Awake()
    {
        Datas = GameObject.FindGameObjectsWithTag("DATA");
        if(Datas.Length >= 2)
        {
            Destroy(Datas[0]);
        }
        DontDestroyOnLoad(transform.gameObject);
    }
    private void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            SceneManager.LoadScene("Game");
        }
    }
}