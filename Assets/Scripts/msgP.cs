using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class msgP : MonoBehaviour
{
    public Text texto;
    public Image imgbase;
    public Image img2;
    public Image img3;
    public Image img4;
    public Image img5;

    //[Range(1f, 10f)] public float distanciaPlaca = 3;
    private GameObject jogador;  //o jogador precisa ter a tag 'player '
    // Start is called before the first frame update
    void Start()
    {
        texto.enabled = false;
        imgbase.enabled = false;
        img2.enabled = false;
        img3.enabled = false;
        img4.enabled = false;
        img5.enabled = false;
        jogador = GameObject.FindWithTag("player");

    }

    // Update is called once per frame
    void Update()
    { 

    }
    void OnTriggerEnter(Collider hit)
    {
        if (hit.tag == "player")
        {
            texto.enabled = true;
            imgbase.enabled = true;
            img2.enabled = true;
            img3.enabled = true;
            img4.enabled = true;
            img5.enabled = true;
            Cursor.visible = true;

        }

    }
    void OnTriggerExit (Collider hit)
    {
        if (hit.tag == "player")
        {
            texto.enabled = false;
            imgbase.enabled = false;
            img2.enabled = false;
            img3.enabled = false;
            img4.enabled = false;
            img5.enabled = false;
            Cursor.visible = false;
        }

    }
}
