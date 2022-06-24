using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public int speed;
    
    private Rigidbody rigid;
    public GameObject ball;
    // Start is called before the first frame update
    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
        
        rigid.velocity = transform.forward * speed;
    }

     public void ResetBall()
     {
        //Instantiate(ball,transform.position, Quaternion.identity);
        Instantiate(ball,transform.position,transform.rotation);
        //transform.position = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
     }

    // Start is called before the first frame update
  
}
