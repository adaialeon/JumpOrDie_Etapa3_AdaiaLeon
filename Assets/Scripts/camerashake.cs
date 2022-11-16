using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Para que la cámara vibre cuando peta una bomba
public class camerashake : MonoBehaviour
{
   [SerializeField]private float duration;
   [SerializeField]private float magnitude;


   void Start()
   {
        //llamar Coroutine
        //StartCoroutine(Shake());
   }
   
   
   
   //Coroutine = es una funcion pero podemos pararla y que se ejecute en el siguiente frame
    public IEnumerator Shake(float duration, float magnitude)
    {
        //yield return 0;
        //para que se ejecute en los segundos que yo decida, en este caso 1 segundo
        //yield return new WaitForSeconds(1f);


        //Almacenar la posicion de la cámara
        Vector3 originalPos = transform.position;
        float elapsed = 0f;

        //Crear un loop
        //Si la condicion no se cumple no ejecuta el código
        while(elapsed < duration)
        {
           
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.position = new Vector3(x + originalPos.x, + originalPos.y, transform.position.z);
            elapsed  += Time.deltaTime;
            yield return 0;

        }

        //Movimiento trambolico de la cámara
        /*for(float i = elapsed; i < duration; i += Time.deltaTime)
      {

        float x = Random.Range(-1f, 1f) * magnitude;
        float y = Random.Range(-1f, 1f) * magnitude;

        transform.position = new Vector3(x + originalPos.x, y + originalPos.y, transform.position.z);
        yield return 0;   

        }*/
    
     //Si la condicion solo se ejecuta una vez
     /*do
     {
        Debug.Log("Shake");
        float x = Random.Range(-1f, 1f) * magnitude;
        float y = Random.Range(-1f, 1f) * magnitude;

        transform.position = new Vector3(x + originalPos.x, y + originalPos.y, transform.position.z);
        elapsed  += Time.deltaTime;
        yield return 0; 

     } while (elapsed < duration);

        /*GameObject[] vidas;

     //Vidas del personaje bucle para recorrer una lista
     foreach(GameObject vida in vidas)
     {
        vida.SetActive(false);
        }*/

    }

}
