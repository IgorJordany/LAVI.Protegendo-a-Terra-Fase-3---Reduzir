using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour {
    private GameObject player;
    public void voltar()
    {
        player = GameObject.Find("PersonagensM");
        Destroy(player);
        player = GameObject.Find("PersonagensF");
        Destroy(player);
        SceneManager.LoadScene("Menu");
    }
}
