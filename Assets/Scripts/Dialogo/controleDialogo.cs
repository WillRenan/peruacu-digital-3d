using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controleDialogo : MonoBehaviour
{
    [Header("Componentes")]
    public GameObject dialogoObj;
    public Image imgBg;
    public Text texto;

    [Header("Configurações")]
    public float velocidadeTexto;

    public void Leitura(Sprite img, string txt)
    {
        dialogoObj.SetActive(true);
        imgBg.sprite = img;
        texto.text = txt;
    }
}
