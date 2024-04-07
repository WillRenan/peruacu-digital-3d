using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogo : MonoBehaviour
{
    public Sprite imgBG;
    public string textPeruacu;

    private controleDialogo cd;

    private void Start()
    {
        cd = FindObjectOfType<controleDialogo>();
    }
    public void Interacao()
    {

    }


    public void OnTriggerEnter(Collider hit)
    {
        if (hit.tag == "player")
        {
            cd.Leitura(imgBG,textPeruacu);
        }
    }
}
