using UnityEngine;

public class MoveObject : MonoBehaviour
{

    public float speed = 5.0f;

    void Start()
    {
        
    }

    void Update()
    {

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        /*transform.position += move * speed * Time.deltaTime;*/
        transform.Translate(move * speed * Time.deltaTime);
        
        /*// Ű �Է¿� ���� �̵�
        float move = Input.GetAxis("Horizontal");
        // ���� * ���ǵ� * Ÿ�ӵ�ŸŸ��
        transform.Translate(Vector3.right * move * speed * Time.deltaTime);*/
    }
}
