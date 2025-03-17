using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = player.transform.position + new Vector3(0, 0.5f, -5);
    }
}
