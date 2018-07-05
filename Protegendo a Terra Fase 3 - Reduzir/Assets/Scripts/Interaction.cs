using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour {
    // Use this for initialization
    private float distance = 8;
    public GameObject panelBox;
    public GameObject luz;
    public GameObject Player;
    public Button botao;

	void Start () {
        panelBox.SetActive(false);
        Player = GameObject.FindWithTag("ativo");
    }
	
	// Update is called once per frame
	void Update () {  
        if(Vector3.Distance(transform.position, Player.transform.position) < distance)
        {
            panelBox.SetActive(true);
            botao.onClick.AddListener(TaskOnClick);
        }
        else
        {
            panelBox.SetActive(false);
        }
    }
    void TaskOnClick()
    {
        DetetorLuz();
    }
    public void DetetorLuz()
    {
        if (luz.activeSelf == true)
        {
            luz.SetActive(false);
        }
        else
        {
            luz.SetActive(true);
        }
    }
}
