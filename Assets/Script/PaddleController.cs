using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public string player;
    public GameObject Wall;
    public Text ScoreText;
    public int score;
    public KeyCode LeftKey;
    public KeyCode RightKey;
    private Rigidbody rigid;
    public ScoreManager ScoreManager;
    public GameOverScreen game;
    public GoalController goal;
    public BallController ball;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text =player + " " + score.ToString();
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         Vector3 movement = Vector3.zero;
        if (Input.GetKey(LeftKey))
        {
           movement = Vector3.back * speed;
        }
        else if (Input.GetKey(RightKey))
        {
           movement = Vector3.forward * speed;
        }
        transform.Translate(movement * Time.deltaTime);
    }
    public void AddScore(int increment)
    {
        score += increment;
        ScoreText.text = player + " " + score.ToString();
        ball.ResetBall();
        if (score >= ScoreManager.MaxScore)
        {
            Lose();
            
        }
    }
    public void Lose()
    {
        Wall.SetActive(true);
        ScoreManager.ListPaddl.Remove(this);
        
        gameObject.SetActive(false);
        
    }
    
}
