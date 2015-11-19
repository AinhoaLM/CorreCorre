using UnityEngine;
using System.Collections;

public class Puntuacion : MonoBehaviour {

    private int puntuacion = 0;
    public TextMesh marcador;
	// Use this for initialization
	void Start () {
        //Nos suscribimos a la notificación de ganar puntos
        NotificationCenter.DefaultCenter().AddObserver(this,"IncrementarPuntos");
        ActualizarMarcador();
    }
	
    void IncrementarPuntos(Notification notifacacion){
        int puntosAIncrementar = (int)notifacacion.data;
        puntuacion += puntosAIncrementar;
        ActualizarMarcador();
        //Debug.Log("Incrementando: "+ puntosAIncrementar+"puntos. Total ganados: "+puntuacion);
    }


    void ActualizarMarcador(){
        marcador.text = puntuacion.ToString();

    }
    // Update is called once per frame
    void Update () {
	
	}
}
