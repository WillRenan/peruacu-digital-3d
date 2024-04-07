using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class totem : MonoBehaviour
{
    public float contaTotem;
    public Text  totalTotem;
    
    
    // Start is called before the first frame update
    void Start()
    {
        contaTotem = 0;
       // transform.rotation = Quaternion.Euler(rotacaoInicial);

    }

    // Update is called once per frame
    void Update()
    {
        totalTotem.text = "Totens: " + contaTotem +" de 6";

        

        if (contaTotem == 6) {
            
            SceneManager.LoadScene("cenaFim");
        }
    }
    void OnTriggerEnter(Collider hit)
    {
        if ((hit.tag == "totem" ) ) {
 
            contaTotem += 1;
           
            
        }

    }
    void OnTriggerExit(Collider hit)
    {
        if (hit.tag == "totem")
        {
          
        }

    }
}
