using System.Security.Cryptography;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5.0f;
    public float jumpForce = 5.0f;
    public Rigidbody rb;


    void Start()
    {
        
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0, moveZ);
        transform.Translate(move * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
