using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Controller : MonoBehaviour
{
    private Vector2 target;
    public float speed;
    public GameObject BloodParticle;



    void Start()
    {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(BloodParticle, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(
            transform.position,
            target,
            speed * Time.deltaTime
        );

        Destroy(gameObject, 0.6f);
    }

}