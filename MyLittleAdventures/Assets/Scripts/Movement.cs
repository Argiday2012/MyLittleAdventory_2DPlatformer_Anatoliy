using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] AudioSource walking;
    private const string Jump = "Jump";
    public float Speed;
    public float JumpForce;
    private Vector3 dir = new Vector3(0, 0, 0);
    private bool flipRight = true;
    private bool inAir;

    //private bool isGrounded;
    private Rigidbody2D rb;
    private Animator _anim;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }

    private void Start()
    {
        
        
    }

    private void flip()
    {
        flipRight = !flipRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }

    private void jump()
    {
            rb.AddForce(transform.up * JumpForce, ForceMode2D.Impulse);
    }

    //private void checkGround()
    //{
    //    Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, 0.3f);
    //    isGrounded = collider.Length > 1f;
    //}
    private void Update()
    {
        
        if(Input.GetButtonDown("Jump") && !inAir)
        {
            inAir = true;
            jump();
            Idle_Walk_JumpAnimation();
        }

        dir.x = Input.GetAxis("Horizontal") * Speed;
        SoundWalking();
    }

    private void FixedUpdate()
    {
        
        transform.position += dir * Time.fixedDeltaTime;
        _anim.SetFloat("Velocity", Input.GetAxis("Horizontal"));
        
        if (dir.x > 0 && flipRight != true)
        {
            flip();
        }
        else if (dir.x < 0 && flipRight == true)
        {
            flip();
        }
        
    }

    private void Idle_Walk_JumpAnimation()
    {
        _anim.Play("Jump");
    }
    

    private void SoundWalking()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            walking.Play();
        }
        else
        {
            walking.Stop();
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            inAir = false;
        }
        else if(collision.gameObject.layer != LayerMask.NameToLayer("Ground"))
        {
            Idle_Walk_JumpAnimation();
        }
    }
}
