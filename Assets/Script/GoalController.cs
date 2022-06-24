using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public GameObject ball;
    public bool isP1;
    public bool isP2;
    public bool isP3;
    public ScoreManager manager;
    public PaddleController paddle;
    

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "ball")
        {
            paddle.AddScore(1);
            manager.CurrentBall--;
            
        }
    }

    // Start is called before the first frame update
   
}
