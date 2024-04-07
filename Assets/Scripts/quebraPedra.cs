using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quebraPedra : MonoBehaviour
{
    public int teste;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == ("player") )
        {
            teste = 5;
            if (picareta.contaPicareta > 0)
            {
                teste = 1;
                //GetComponent<AudioSource>().Play();
                GetComponent<Renderer>().enabled = false;
                GetComponent<Collider>().enabled = false;
                Destroy(gameObject, 3);
            }
               

        }

    }
}
