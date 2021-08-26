using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private SpriteRenderer _spriteRenderer;
    private Animator _animator;
    private Rigidbody2D _rigidbody2D;
    
    // Start is called before the first frame update
    void Start()
    {

        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) )
        {
            _spriteRenderer.flipX= false;
            setWalkAnimation();
            _rigidbody2D.velocity = new Vector2(4,_rigidbody2D.velocity.y);
        }
        else
        {
            setIdleAnimation();
            _rigidbody2D.velocity = new Vector2(0,_rigidbody2D.velocity.y);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _spriteRenderer.flipX = true;
            setWalkAnimation();
            _rigidbody2D.velocity = new Vector2(-4,_rigidbody2D.velocity.y);
        }
        
        if (Input.GetKeyUp(KeyCode.Space))
        {
            _rigidbody2D.AddForce(Vector2.up * 7, ForceMode2D.Impulse);
            setAtackAnimation();
        }
        
        if (Input.GetKeyUp(KeyCode.Z))
        {
            setJumpAnimation(); 
        }
        
        if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.X)  )
        {
            _spriteRenderer.flipX= false;
            setWalkAnimation();
            _rigidbody2D.velocity = new Vector2(10,_rigidbody2D.velocity.y);
        }
        else
        {
            setIdleAnimation();
            _rigidbody2D.velocity = new Vector2(0,_rigidbody2D.velocity.y);
        }
        
        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.X))
        {
            _spriteRenderer.flipX = true;
            setWalkAnimation();
            _rigidbody2D.velocity = new Vector2(-10,_rigidbody2D.velocity.y);
        }
        
    }
    
    private void setIdleAnimation(){
        _animator.SetInteger("Estado",0);
    }

    private void setWalkAnimation(){
        _animator.SetInteger("Estado",1);
    }
    
    private void setJumpAnimation(){
        _animator.SetInteger("Estado",2);
    }
    
    private void setRunAnimation(){
        _animator.SetInteger("Estado",3);
    }

    private void setAtackAnimation(){
        _animator.SetInteger("Estado",4);
    }
    
}
