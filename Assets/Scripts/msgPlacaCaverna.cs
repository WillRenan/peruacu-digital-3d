using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class msgCaverna : MonoBehaviour
{
    public Text texto;
    public Image imgbase ;
    [Range(1f,10f)]public float distanciaPlaca = 3;
    private GameObject jogador;  //o jogador precisa ter a tag 'player '
    void Start()
    {
        texto.enabled = false;
        imgbase.enabled = false;
        jogador = GameObject.FindWithTag("player");

        
    }

 
    void Update()
    {
        if(Vector3.Distance(transform.position, jogador.transform.position) < distanciaPlaca)
        {
            texto.enabled = true;
            //imgbase.enabled = true;
        }
        else
        {
            texto.enabled = false;
           // imgbase.enabled = false;
        }
        
    }
}
