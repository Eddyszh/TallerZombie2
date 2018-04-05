using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Citizen : MonoBehaviour
{
    public CitizenInformation cInformation;                             //Declara la estructura que contiene la información del ciudadano.
	void Start ()                                                       //Método Start, asigna la edad y el nombre a cada ciudadano de manera aleatoria. El nombre esta almacenado en un enumerador.
    {
		cInformation.age = Random.Range(15, 100);
        cInformation.name = (CitizenName)Random.Range(0, 20);
    }	
	
    public CitizenInformation CitizenInfo()                             //Función que devuelve la estructura que contiene loa información del ciudadano.
    {
        return cInformation;
    }
}

public enum CitizenName                                                 //Enumerador que contiene los nombres que se asignaran de manera aleatoria.
{
    Adolfo,
    Ramiro,
    Bob,
    Jimmy,
    Josefo,
    Leopoldo,
    Cirilo,
    Fabio,
    Yisus,
    Jasinto,
    Arnulfa,
    Berta,
    Gregoria,
    Gertrudis,
    Lola,
    Marta,
    Eva,
    Beatriz,
    Facunda,
    Pepa
}

public struct CitizenInformation                                        //Estructura que contiene la información del ciudadano.
{
    public int age;
    public CitizenName name;
}