using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    void Start()
    {
        Debug.Log("Start: 시작시 호출");
    }

    void Update()
    {
        Debug.Log("Updated: 프레임마다 호출");
    }

    private void FixedUpdate()
    {
        Debug.Log("Fixed Updated: 물리연산에 사용");
    }


}
