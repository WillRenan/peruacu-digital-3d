using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ligaLanterna : MonoBehaviour
{
    public bool ligaDesliga;
    public Text StatusLanterna;
    // Start is called before the first frame update

    void Start()
    {
        ligaDesliga = false;
        GetComponent<Light>().enabled = ligaDesliga;
        StatusLanterna.text = "OFF";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) )
        {
            ligaDesliga = !ligaDesliga;
            GetComponent<Light>().enabled = ligaDesliga;
            GetComponent<AudioSource>().Play();
            if (ligaDesliga)
            {
                StatusLanterna.text = "ON";
            }else
            {
                StatusLanterna.text = "OFF";
            }
        }
        
    }
}
