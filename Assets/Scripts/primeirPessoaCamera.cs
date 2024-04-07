using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class primeirPessoaCamera : MonoBehaviour{

    public Transform characterBody;
    public Transform characterHead;
    //-----------Rotação --------
    float rotateX = 0;
    float rotateY = 0;
    //-----------Sensibilidade do Mouse -------------------
    public float sensitivityX = 0.5f;
    public float sensitivityY = 0.5f;
    //-----------Angulos de visão -------------------------
    float angleYMin = -55; // angulo minimo de visão da rotação em Y
    float angleYMax = 90; //angulo maximo de visoão da rotação em Y
    /// </summary>
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void LateUpdate()
    {
        transform.position = characterHead.position;
    }

    // Update is called once per frame
    void Update()
    {
        float verticalDelta = Input.GetAxisRaw("Mouse Y") * sensitivityY;
        float horizontalDelta = Input.GetAxisRaw("Mouse X") * sensitivityX;

        rotateX += horizontalDelta;
        rotateY += verticalDelta;

        rotateY = Mathf.Clamp(rotateY, angleYMin,angleYMax); // Função Clamp, limita a rotação em um angulo max e min
        characterBody.localEulerAngles = new Vector3(0, rotateX,0);
        transform.localEulerAngles = new Vector3(-rotateY, rotateX, 0);
    }
}
