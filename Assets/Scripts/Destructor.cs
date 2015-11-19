﻿using UnityEngine;
using System.Collections;

public class Destructor : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // OnTriggerEnter2D is called when the Collider2D other enters the trigger (2D physics only)
    void OnTriggerEnter2D(Collider2D other)
    {

        //Para destruir el personaje cuando se caiga
        if(other.tag == "Player")
        {
            Debug.Break();
            //POR HACER...  HACER QUE SE MUESTRE LA PUNTUACIÓN
            //HA MUERTO EL PERSONAJE
        } else{
            //Para destruir los bloques
            Destroy(other.gameObject);
        }

    }

   
}
