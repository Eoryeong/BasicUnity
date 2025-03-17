using UnityEngine;

public class FunctionExample : MonoBehaviour
{
    void SayHello()
    {
        Debug.Log("Hello World");
    }

    int AddNumbers(int a, int b)
    {
        return a +b;
    }

    void Start()
    {
        SayHello();
        int total = AddNumbers(2, 5);
        Debug.Log($"total : {total}");
    }

    void Update()
    {
        
    }
}
