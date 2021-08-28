using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problema1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola mundo!");

        int[] nums = new int[] {8, 1, 2, 4, 6};

        int[] result = ItemsLessThanElement(nums);

        foreach (var item in result)
        {
            Debug.Log(item);
        }
    }

    private int[] ItemsLessThanElement(int[] nums)
    {
        /*
        Dado un arreglo de números enteros nums, para cada elemento nums[ i ]
        encontrar cuántos números en el arreglo son menores que dicho elemento. Regresar el resultado en un arreglo.
        Ejemplo. 
        Input: nums = [8,1,2,2,3]
        Output: [4,0,1,1,3]
        */
        return nums;
    }
}
