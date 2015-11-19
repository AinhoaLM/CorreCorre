using UnityEngine;
using System.Collections;

public class Puntuacion : MonoBehaviour {

    private int puntuacion = 0;

	// Use this for initialization
	void Start () {
        //Nos suscribimos a la notificación de ganar puntos
        NotificationCenter.DefaultCenter().AddObserver(this,"IncrementarPuntos");
	}
	
    void IncrementarPuntos(Notification notifacacion){
        int puntosAIncrementar = (int)notifacacion.data;
        puntuacion += puntosAIncrementar;
        Debug.Log("Incrementando: "+ puntosAIncrementar+"puntos. Total ganados: "+puntuacion);
    }
    // Update is called once per frame
    void Update () {
	
	}
}
