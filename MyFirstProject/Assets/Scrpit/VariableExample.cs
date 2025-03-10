using UnityEngine;

public class VariableExample : MonoBehaviour
{
    public int playerScore = 0;
    public float speed = 5.5f;
    public string playerName = "Hero";
    public bool isGameOver = false;

    void Start()
    {
        Debug.Log("Player Name : " + playerName);
        Debug.Log("Player Score : " + playerScore);
        Debug.Log("Player Speed : " + speed);
        Debug.Log("Is Game Over? : " + isGameOver);
    }

    void Update()
    {
        
    }
}
