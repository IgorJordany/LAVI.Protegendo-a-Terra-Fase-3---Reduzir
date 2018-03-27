using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSelect : MonoBehaviour {
    public Texture[] Personagem;
    private int SelecaoAtual;

    private void Start()
    {
        SelecaoAtual = 0;
    }
    void OnGUI()
    {
        //selecao do personagem
        if (GUI.Button(new Rect(Screen.width / 2 - Screen.width / 4, Screen.height / 2 - Screen.height / 2.2f, Screen.width / 2, Screen.height / 1.2f), ""))
        {
            DATA.PersonagemAInstanciar = SelecaoAtual;
            SceneManager.LoadScene("Game"); //mudar cena
        }
            if (SelecaoAtual == 0)
        {
            GUI.DrawTexture(new Rect(Screen.width / 2 - Screen.width / 4, Screen.height / 2 - Screen.height / 2.2f, Screen.width / 2, Screen.height / 1.2f), Personagem[SelecaoAtual]);
            //mudar selecao proximo
            if (GUI.Button(new Rect(Screen.width / 1.3f, Screen.height / 2.2f, Screen.width / 6.5f, Screen.height / 5), "PROXIMO"))
            {
                SelecaoAtual = SelecaoAtual + 1;
            }
            //mudar selecao anterior
            if (GUI.Button(new Rect(Screen.width / 13, Screen.height / 2.2f, Screen.width / 6.5f, Screen.height / 5), "ANTERIOR"))
            {
                SelecaoAtual = 4;
            }
        }
        if(SelecaoAtual > 0 && SelecaoAtual <(Personagem.Length - 1))
        {
            GUI.DrawTexture(new Rect(Screen.width / 2 - Screen.width / 4, Screen.height / 2 - Screen.height / 2.2f, Screen.width / 2, Screen.height / 1.2f), Personagem[SelecaoAtual]);
            //mudar selecao proximo
            if (GUI.Button(new Rect(Screen.width / 1.3f, Screen.height / 2.2f, Screen.width / 6.5f, Screen.height / 5), "PROXIMO"))
            {
                SelecaoAtual = SelecaoAtual + 1;
            }
            //mudar selecao anterior
            if (GUI.Button(new Rect(Screen.width / 13, Screen.height / 2.2f, Screen.width / 6.5f, Screen.height / 5), "ANTERIOR"))
            {
                SelecaoAtual = SelecaoAtual - 1;
            }
        }
        if(SelecaoAtual >= (Personagem.Length - 1))
        {
            GUI.DrawTexture(new Rect(Screen.width / 2 - Screen.width / 4, Screen.height / 2 - Screen.height / 2.2f, Screen.width / 2, Screen.height / 1.2f), Personagem[SelecaoAtual]);
            //mudar selecao proximo
            if (GUI.Button(new Rect(Screen.width / 1.3f, Screen.height / 2.2f, Screen.width / 6.5f, Screen.height / 5), "PROXIMO"))
            {
                SelecaoAtual = 0;
            }
            //mudar selecao anterior
            if (GUI.Button(new Rect(Screen.width / 13, Screen.height / 2.2f, Screen.width / 6.5f, Screen.height / 5), "ANTERIOR"))
            {
                SelecaoAtual = SelecaoAtual - 1;
            }
        }
    }
}