using System;
using UnityEngine;

public class LoopExample : MonoBehaviour
{

    
    void Start()
    {
        // for�� : 1���� 10���� ���

        for(int i = 1; i<=10; i++)
        {
            Debug.Log(i);
        }

        int counter = 0;
        while(counter < 5)
        {
            Debug.Log("Counter : " + counter);
            counter++;
        }
    }

    
    void Update()
    {
        
    }
}
