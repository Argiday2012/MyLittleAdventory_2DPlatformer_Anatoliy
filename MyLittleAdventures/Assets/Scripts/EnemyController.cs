using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform Hero;

    public float Speed;
    public float DistToHero;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, Hero.position);

        if(distanceToPlayer < DistToHero)
        {
            StartFollow();
        }
        else
        {
            StopFollow();
        }

    }

    private void StartFollow()
    {
        if(Hero.position.x < transform.position.x)
        {
            rb.velocity = new Vector2(-Speed, 0 * Time.deltaTime);
            transform.localScale = new Vector2(0.3f, 0.3f);
        }
        else if (Hero.position.x > transform.position.x)
        {
            rb.velocity = new Vector2(Speed, 0 * Time.deltaTime);
            transform.localScale = new Vector2(-0.3f, 0.3f);
        }
    }

    private void StopFollow()
    {
        rb.velocity = new Vector2(0, 0);
    }
}
