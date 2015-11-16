using UnityEngine;
using System.Collections;

public class SeguirPersonaje : MonoBehaviour {

	public Transform personaje;
	public float separacion = 4f;
	
	// Update is called once per frame
	void Update () {
		//Camara sigue al personaje
		transform.position = new Vector3(personaje.position.x+separacion,transform.position.y,transform.position.z);
	}
}
