using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    private GameObject[] characterList;
    private int selecaoAtual;
    private GameObject ativo;
    public GameObject personagem;

    private void Start()
    {
        selecaoAtual = 0;
        characterList = new GameObject[transform.childCount];
        //Preenche vetor com os modelos
        for (int i = 0; i < transform.childCount; i++)
        {
            characterList[i] = transform.GetChild(i).gameObject;
        }
        //Desabilita personagem
        foreach (GameObject go in characterList)
        {
            go.SetActive(false);
        }
        if (characterList[0])
        {
            characterList[0].SetActive(true);
            characterList[selecaoAtual].gameObject.tag = "ativo";
        }
    }
    public void NextPlayer()
    {
        if (selecaoAtual >= 0 && selecaoAtual < 5)
        {
            characterList[selecaoAtual].SetActive(false);
            characterList[selecaoAtual].gameObject.tag = "des";
            selecaoAtual = selecaoAtual + 1;
            characterList[selecaoAtual].SetActive(true);
            characterList[selecaoAtual].gameObject.tag = "ativo";
        }
        else
        {
            if (selecaoAtual == 5)
            {
                characterList[selecaoAtual].SetActive(false);
                characterList[selecaoAtual].gameObject.tag = "des";
                selecaoAtual = 0;
                characterList[selecaoAtual].SetActive(true);
                characterList[selecaoAtual].gameObject.tag = "ativo";
            }
        }
    }
    public void BackPlayer()
    {
        if (selecaoAtual == 0)
        {
            characterList[selecaoAtual].SetActive(false);
            characterList[selecaoAtual].gameObject.tag = "des";
            selecaoAtual = 5;
            characterList[selecaoAtual].SetActive(true);
            characterList[selecaoAtual].gameObject.tag = "ativo";
        }
        else
        {
            if (selecaoAtual > 0 && selecaoAtual <= 5)
            {
                characterList[selecaoAtual].SetActive(false);
                characterList[selecaoAtual].gameObject.tag = "des";
                selecaoAtual = selecaoAtual - 1;
                characterList[selecaoAtual].SetActive(true);
                characterList[selecaoAtual].gameObject.tag = "ativo";
            }
        }
    }
    public void PlayerSelect()
    {
        GameObject.FindGameObjectsWithTag("ativo");
        characterList[selecaoAtual].gameObject.name = "player";
        DontDestroyOnLoad(transform.gameObject);
        SceneManager.LoadScene("Game");
    }
}