using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public CitizenInformation cInformation;                                                                             //Declara la estructura que contiene la información del ciudadano.
    public ZombieInformation zInformation;                                                                              //Declara la estructura que contiene la información del zombie.
    void Start ()
    {
        int spawn = -1;                                                                                                 //Inicia variable en -1 para iniciar el default del switch y crear el heroe.
        zInformation.color = new Color[] { Color.cyan, Color.green, Color.magenta };                                    //Asigna los valores de color al array del color del zombie.
        for (int i = 0; i < Random.Range(10, 20); i++)                                                                  //Bucle que crea las primitivas de cubo para ciudadano, zobie y heroe. Contiene un switch que asigna la identidad a cada primitiva.
        {
            GameObject humanoid = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 pos = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            humanoid.transform.position = pos;
            switch(spawn)
            {
                case 1:
                    humanoid.name = "Citizen";
                    humanoid.AddComponent<Citizen>();
                    break;
                case 2:
                    humanoid.name = "Zombie";
                    humanoid.AddComponent<Zombie>();
                    humanoid.GetComponent<Renderer>().material.color = zInformation.color[Random.Range(0, 3)];
                    break;
                default:
                    humanoid.name = "Hero";
                    humanoid.gameObject.tag = "Player";
                    humanoid.AddComponent<Hero>();
                    humanoid.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                    break;
            }
            spawn = Random.Range(1, 3);                                                                                 //Valor aleatorio para añadir la identidad al cubo.
        }
    }	
}
