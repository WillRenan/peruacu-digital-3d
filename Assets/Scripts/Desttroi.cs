using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desttroi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider hit)
    {
        if (hit.tag == "totem")
        {
            GetComponent<AudioSource>().Play();
            GetComponent<Renderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
            // Destroy(this.gameObject,3);

        }


    }
}
