using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour
{
    public int puntosGanados = 5;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // OnTriggerEnter2D is called when the Collider2D other enters the trigger (2D physics only)
    public void OnTriggerEnter2D(Collider2D collision)
    {
        NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
        Destroy(gameObject);
        //Debug.Log("Tocado");
    }
}
