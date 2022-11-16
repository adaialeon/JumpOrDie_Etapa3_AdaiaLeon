using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paradaxeffect : MonoBehaviour
{

    //para poder mover cada capa
    [SerializeField] private float parallaxMultiplier;

    //cámara almacenar posicion
    private Transform cameraTransform;
    private Vector3 cameraPreviousPos;

    //para que desplace el fondo y no se vean cortes
    //alacenar el ancho del sprite
    private float spriteWidth;
    //alacenar pose inicial del sprite
    private float startPos;

    void Start()
    {   
        //accedemos a la camara principal
        cameraTransform = Camera.main.transform;

        //almacenar posicion previa de la cámara
        cameraPreviousPos = cameraTransform.position;

        //ancho del sprite
        spriteWidth = GetComponent<SpriteRenderer>().bounds.size.x;

        //pose
        startPos = transform.position.x;
    }

    void LateUpdate()
    {
        //movimiento de los sprites (velocidad)
        float x = (cameraTransform.position.x - cameraPreviousPos.x) * parallaxMultiplier;

        //saber cuanto espacio se ha movido la imagen
        float spriteMoveAmount = cameraTransform.position.x * (1 -parallaxMultiplier);

        //movimiento del fondo solo en la X
        transform.Translate(new Vector3(x, 0f, 0f));

        //actualizar la posición de la cámaras
        cameraPreviousPos = cameraTransform.position;

        //cuando llega al final del sprite lo vuelve a colocar en medio de la cámara
        if(spriteMoveAmount > startPos + spriteWidth) //= hemos llegado al borde del sprite
        {
            transform.Translate(new Vector3(spriteWidth, 0f, 0f));

            //a la pose inicial le sumaremos el ancho del sprite
            startPos += spriteWidth;
        }
        else if(spriteMoveAmount < startPos - spriteWidth) //lo mismo pero para que se mueva a la izquierda
        {
              transform.Translate(new Vector3(spriteWidth, 0f, 0f));

            //a la pose inicial le sumaremos el ancho del sprite
            startPos -= spriteWidth;
        }
        
    }
}
