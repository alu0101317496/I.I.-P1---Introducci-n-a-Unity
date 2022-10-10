using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terrain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject sphere = GameObject.FindGameObjectsWithTag("Esfera")[0];
        GameObject tree = GameObject.FindGameObjectsWithTag("Arbol")[0];
        GameObject pj = GameObject.FindGameObjectsWithTag("Personaje")[0];
        GameObject cube = GameObject.FindGameObjectsWithTag("Cubo")[0];
        GameObject cilinder = GameObject.FindGameObjectsWithTag("Cilindro")[0];
        Debug.Log("I'm a " + sphere.tag);
        Debug.Log("I'm an " + tree.tag);
        Debug.Log("I'm a " + pj.tag);
        Debug.Log("I'm a " + cube.tag);
        Debug.Log("I'm a " + cilinder.tag);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
