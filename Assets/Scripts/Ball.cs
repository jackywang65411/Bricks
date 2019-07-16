using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ballspeedX;
    public float ballspeedY;
    public bool Ballstart;
    public GameObject Player;
    public GameObject BallRE;
    public Rigidbody2D ballrigidbody2D;
    

    void Start()
    {
        //ballspeedX = Random.Range(-5,6);
        ballspeedY = 5f;
        Ballstart = false;
        

        ballrigidbody2D = GetComponent<Rigidbody2D>();
        
    }


    void Update()
    {
        if (Ballstart == false && Input.GetKeyDown(KeyCode.Space))
        {
            ballspeedX = Random.Range(-4f, 5f);//隨機發球方向
            ballrigidbody2D.velocity = new Vector2(ballspeedX, ballspeedY);
            Ballstart = true;
            
        }
        if (transform.localPosition.y < -5)
        {
            gameObject.transform.position = BallRE.transform.position;
            ballrigidbody2D.velocity = Vector2.zero;
            Life.LifeValue--;
            Ballstart = false;
        }
        if (Ballstart == false)
        {
            gameObject.transform.position = BallRE.transform.position;
        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            ballrigidbody2D.velocity = new Vector2((gameObject.transform.localPosition.x - Player.transform.localPosition.x) * 3, ballspeedY);

        }
        //需優化 不使用collider比較省資源 V

    }
}
