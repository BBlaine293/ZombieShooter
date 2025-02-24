﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rocket : MonoBehaviour
{
    public float moveSpeed = 100.0f;
    public int damage = 1;
    public GameObject explosion;
    public Transform rocket;
    
   

    private void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(transform.up * moveSpeed);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
            Instantiate(explosion, rocket.position, transform.rotation = Quaternion.identity);
        other.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
       
        
            Die();
            Destroy(gameObject);
        
       

       


    }
    private void OnBecameInvisible()
    {
        Die();
    }
    private void Die()
    {
        Destroy(gameObject);
    }
}

