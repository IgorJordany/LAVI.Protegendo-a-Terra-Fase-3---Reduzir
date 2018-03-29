using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour
{
    private GameObject[] characterList;
    private int selecaoAtual;

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
        }
    }
    public void NextPlayer()
    {
        if (selecaoAtual >= 0 && selecaoAtual < 5)
        {
            characterList[selecaoAtual].SetActive(false);
            selecaoAtual = selecaoAtual + 1;
            characterList[selecaoAtual].SetActive(true);
        }
        if (selecaoAtual == 5)
        {
            characterList[selecaoAtual].SetActive(false);
            selecaoAtual = 0;
            characterList[selecaoAtual].SetActive(true);
        }
    }
    public void BackPlayer()
    {
        if (selecaoAtual == 0)
        {
            characterList[selecaoAtual].SetActive(false);
            selecaoAtual = 5;
            characterList[selecaoAtual].SetActive(true);
        }
        if (selecaoAtual > 0 && selecaoAtual <= 5)
        {
            characterList[selecaoAtual].SetActive(false);
            selecaoAtual = selecaoAtual - 1;
            characterList[selecaoAtual].SetActive(true);
        }
    }
}
