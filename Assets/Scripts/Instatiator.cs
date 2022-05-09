using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instatiator : MonoBehaviour
{
    public GameObject objectToClone;
    //GameObject es un tipo de variable (que es específico de Unity) que permite almacenar un GameObject en una Variable y manipularlo.
    public void CloneObject()
    {
        Instantiate(objectToClone);
    }
}
