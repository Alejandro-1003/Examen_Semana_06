using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaController : MonoBehaviour
{
    Rigidbody2D rb;
    
    public float velocityX = 0.1f;
    public float velocityY = 0f;
    public GameObject bala1;
    public GameObject bala2;
    public bool partirse = true;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(this.gameObject,20);
    }

    void Update()
    {
        rb.velocity = new Vector2(velocityX, rb.velocity.y);
    }


   
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
           Debug.Log("Muerte");
           Destroy(other.gameObject);
           Destroy(this.gameObject);
        }
        
    }
     
   }


