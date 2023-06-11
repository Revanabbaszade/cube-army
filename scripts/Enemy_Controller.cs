using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Controller : MonoBehaviour
{
    [Header("Target")]
    private Transform playerPos;

    [Header("Gameplay")]
    public float speed;
    public int healt;
    internal Action OnDeath;
    public GameObject BloodParticle;

    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }


    void Update()
    {
        transform.position = Vector2.MoveTowards(
            transform.position,
            playerPos.position,
            speed * Time.deltaTime);

        if (healt <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(BloodParticle, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Bullet")
        {
            healt--;
        }
    }
}