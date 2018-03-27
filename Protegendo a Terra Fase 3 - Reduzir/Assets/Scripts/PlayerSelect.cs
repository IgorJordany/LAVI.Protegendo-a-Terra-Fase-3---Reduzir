using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour {
    public Texture[] Personagem;
    public int SelecaoAtual;

    private void Start()
    {
        SelecaoAtual = 0;
    }
    void OnGUI()
    {
        if(SelecaoAtual == 0)
        {
            GUI.DrawTexture(new Rect(Screen.width / 2 - Screen.width / 4, Screen.height / 2 - Screen.height / 2.2f, Screen.width / 2, Screen.height / 1.2f), Personagem[SelecaoAtual]);
            if (GUI.Button(new Rect(Screen.width / 1.3f, Screen.height / 2.2f, Screen.width / 6.5f, Screen.height / 5), "PROXIMO"))
            {
                SelecaoAtual = SelecaoAtual + 1;
            }
        }
        if(SelecaoAtual > 0 && SelecaoAtual <(Personagem.Length - 1))
        {
            GUI.DrawTexture(new Rect(Screen.width / 2 - Screen.width / 4, Screen.height / 2 - Screen.height / 2.2f, Screen.width / 2, Screen.height / 1.2f), Personagem[SelecaoAtual]);
            if (GUI.Button(new Rect(Screen.width / 1.3f, Screen.height / 2.2f, Screen.width / 6.5f, Screen.height / 5), "PROXIMO"))
            {
                SelecaoAtual = SelecaoAtual + 1;
            }
        }
        if(SelecaoAtual >= (Personagem.Length - 1))
        {
            GUI.DrawTexture(new Rect(Screen.width / 2 - Screen.width / 4, Screen.height / 2 - Screen.height / 2.2f, Screen.width / 2, Screen.height / 1.2f), Personagem[SelecaoAtual]);
            if (GUI.Button(new Rect(Screen.width / 1.3f, Screen.height / 2.2f, Screen.width / 6.5f, Screen.height / 5), "PROXIMO"))
            {
                SelecaoAtual = SelecaoAtual + 1;
            }
        }
    }
}