using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public CitizenInformation cInfo;                                                        //Declara la estructura que contiene la información del ciudadano.
    public ZombieInformation zInfo;                                                         //Declara la estructura que contiene la información del zombie.	
	void Start ()                                                                           //Método Start, añade los scripts de movimiento al heroe, añade la camara principal como hijo y le añade un script de "mira".
    {
        gameObject.AddComponent<FPSAim>();
        gameObject.AddComponent<FPSMove>().speed = Random.Range(0.5f, 0.10f);
        gameObject.AddComponent<Rigidbody>().freezeRotation = enabled;
        Camera.main.gameObject.transform.localPosition = gameObject.transform.position;
        Camera.main.transform.SetParent(gameObject.transform);
        Camera.main.gameObject.AddComponent<FPSAim>();
	}
	
	public void OnCollisionEnter(Collision collision)                                       //Método OnCollisionEnter, compara si con el cubo que colisione es ciudadano o zombie, muestre el mesaje correspondiente.
    {
        if(collision.gameObject.GetComponent<Citizen>())
        {
            cInfo = collision.gameObject.GetComponent<Citizen>().CitizenInfo();             //Asigna la información del ciudadano para usar en el mensaje.
            Debug.Log("Hola soy " +  cInfo.name + " y tengo " + cInfo.age);                 //Mensaje que da el ciudadano al entrar en contacto.
        }
        
        if (collision.gameObject.GetComponent<Zombie>())
        {
            zInfo = collision.gameObject.GetComponent<Zombie>().ZombieInfo();               //Asigna la información del zombie para usar en el mensaje.
            Debug.Log("Waaaarrrr quiero comer " + zInfo.taste);                             //Mensaje que da el zombie al entrar en contacto.
        }
    }
}
