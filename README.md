# I.I. P1 - Introducción a Unity
**Autor:** Lucas Hernández Abreu\
**email**: alu0101317496@ull.edu.es

## Resultados
![Gif con los resultados](./Results.gif)

## Descripción del proyecto
El proyecto ha sido creado en Unity y se ha implementado el uso de 1 script 
que reconoce las tags de los objetos dentro de la escena. 

El código utilizado para cumplimentar la tarea del script es el siguiente:
```cs
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
        GameObject terrain = GameObject.FindGameObjectsWithTag("Terreno")[0];
        Debug.Log("I'm a " + sphere.tag);
        Debug.Log("I'm an " + tree.tag);
        Debug.Log("I'm a " + pj.tag);
        Debug.Log("I'm a " + cube.tag);
        Debug.Log("I'm a " + cilinder.tag);
        Debug.Log("I'm a " + terrain.tag);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
```

Los objetos añadidos son:
- Arbol
- Esfera
- Cubo
- Personaje
- Cilindro
- Terreno

Para colorear el terreno he usado las texturas que se encontraban en el mismo
pack de assets que los arboles.

Para todo el proyecto solo se ha usado la interfaz de la aplicación.


### Lista de tareas

- [x] Incluir objetos 3D básicos
- [x] Incluir en el proyecto el paquete Starter Assets
- [x] Incluir un objeto libre de la Asset Store que no sea de los starter Assets
- [x] Crear un terreno
- [x] Cada objeto debe tener una etiqueta que lo identifique
- [x] Utilizar prefabs de Starter Asset FPS o Third Person
- [x] Agregar un script que escriba en la consola los objetos que se han utilizado

