using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    void Start()
    {
        Debug.Log("Start: ���۽� ȣ��");
    }

    void Update()
    {
        Debug.Log("Updated: �����Ӹ��� ȣ��");
    }

    private void FixedUpdate()
    {
        Debug.Log("Fixed Updated: �������꿡 ���");
    }


}
