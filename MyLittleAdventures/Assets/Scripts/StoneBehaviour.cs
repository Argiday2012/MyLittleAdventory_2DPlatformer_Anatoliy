using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneBehaviour : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private float lifeTime = 3f;
    [SerializeField] private Movement _movement;
    public GameObject Enemy;

    private void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    private void Update()
    {
            transform.position += transform.right * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            Debug.Log("Yes");
            Destroy(gameObject);
        }
    }
}
