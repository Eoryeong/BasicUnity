using UnityEngine;

public class ConditionExaple : MonoBehaviour
{
    // �����ڿ� ���ǹ�
    public int health = 100;

    void Start()
    {
        
    }

    void Update()
    {
        health -= 1;
        Debug.Log("Health: " + health);

        if(health <= 0)
        {
            Debug.Log("�׾�...�� �ڳ�");
        }
    }
}
