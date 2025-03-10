using UnityEngine;

public class VariableScript : MonoBehaviour
{
    //변수 선언
    public int playerScore = 0;
    public float speed = 5.5f;
    public string playerName = "Hero";
    public bool isGameOver = false;

    public int health = 100;


    void Start()
    {
        //변수출력
        Debug.Log("Player Name : " + playerName);
        Debug.Log("Player Score : " + playerScore);
        Debug.Log("Speed : " + speed);
        Debug.Log("Is Game Over? : " + isGameOver);
    }
        //연산자와 조건문

   
    
    void Update()
    {
        health -= 1; //체력 감소
        Debug.Log("Health: " + health);

        //조건문
        if(health <=0)
        {
            Debug.Log("Game Over!");
        }
    }
}
