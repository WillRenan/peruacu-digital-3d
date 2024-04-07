using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class picareta : MonoBehaviour
{
    public static int contaPicareta;
    public Text totalPicareta;
    

    // Start is called before the first frame update
    
    
    void Start()
    {
        contaPicareta = 0;
    }

    // Update is called once per frame
    void Update()
    {
        totalPicareta.text = contaPicareta + " ";
    }
    void OnTriggerEnter(Collider hit)
    {
        if ((hit.tag == "picareta"))
        {

            contaPicareta += 1;
         

        }

    }
    

}
