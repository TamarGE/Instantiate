using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instatiator : MonoBehaviour
{
    public GameObject objectToClone;
    //GameObject es un tipo de variable (que es específico de Unity) que permite almacenar un GameObject en una Variable y manipularlo.
    public int num;

    public void CloneObject()
    {
        int i = 1;
        while (i <= num)
        {
            Instantiate(objectToClone);
            i++;
        }
        
    }
}
