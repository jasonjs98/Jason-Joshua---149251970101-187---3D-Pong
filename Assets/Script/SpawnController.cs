using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    
    public BallController bola;
    
    private float timer;
    
    public GameObject ball;
    private List<GameObject> limit;
    // Start is called before the first frame update
    void Start()
    {
        limit = new List<GameObject>();
        timer = 0;
        //Instantiate(ball,transform.position,Quaternion.identity);
    }

    public void InstantiateBall()
    {
        Instantiate(ball,transform.position,transform.rotation);
    }

    
    
    
}
