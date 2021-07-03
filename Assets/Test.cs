using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 4, 7, 2, 9, 20 };
        for (int i = 0; i<5; i++ )
        {
            Debug.Log(array[i]);
        }
        for (int i =4; i>= 0; i--)
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
