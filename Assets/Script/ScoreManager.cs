using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public List<PaddleController> ListPaddl =new List<PaddleController>();
    private float timer;
    public GameOverScreen Gameover;
    public List<SpawnController> ListSpawn = new List<SpawnController>();
    public int MaxBall;
    public int CurrentBall;
    public BallController ball;
    public int MaxScore;
    public float spawnInterval;

    

    void Update()
     {
        
         
         if(ListPaddl.Count == 1)
         {
             GameOver();
         }

          timer += Time.deltaTime;

        if (timer > spawnInterval)
        {
           
            
            if(CurrentBall < MaxBall)
            {
                int rand = Random.Range(0,ListSpawn.Count);
                ListSpawn[rand].InstantiateBall();
                CurrentBall++;
            }
            
            timer = 0;
        }
     }
     public void GameOver()
     {
         Gameover.gameover();
         
     }
}
