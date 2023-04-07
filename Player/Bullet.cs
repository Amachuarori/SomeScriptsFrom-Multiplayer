using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D myRigidBody;
    [SerializeField] float bulletSpeed = 5f;
    EnemyMovement enemy; 
    float xSpeed;
    PlayerMovement player;
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerMovement>();
        xSpeed = player.transform.localScale.x * bulletSpeed;
    }

    void Update()
    {
        myRigidBody.velocity = new Vector2(xSpeed, 0f);
        transform.localScale = new Vector3(player.transform.localScale.x, 1f, 1f);
    }

    

    void OnTriggerEnter2D(Collider2D other){
        
        if(other.tag == "Ground" || other.tag == "WallForBullets"){
            Destroy(gameObject);
        } 
    }
    
}
