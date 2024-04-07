using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroiTotem : MonoBehaviour
  
{
    public GameObject luz;
    public GameObject fumaca;
    void OnTriggerEnter(Collider hit)
    {
        if (hit.tag == "player")
        {
            GetComponent<AudioSource>().Play();
            GetComponent<Renderer>().enabled = false;
            GetComponent<Collider>().enabled = false;

            luz.GetComponent<Light>().enabled = false;
            fumaca.GetComponent<Renderer>().enabled = false;
             // Destroy(this.gameObject,3);

        }

        
    }
}
