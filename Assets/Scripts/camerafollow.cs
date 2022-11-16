using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{   

    //almacenamos a la Elfa
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        //posición cámara = posición personaje
       transform.position = new Vector3(target.position.x, target.position.y, transform.position.z); 
    }
}
