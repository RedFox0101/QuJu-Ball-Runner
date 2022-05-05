using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBall : MonoBehaviour
{

    public GameObject SoundMove, SoundCoin, SoundDamage, SoundJump, PosSpawn; 
    [SerializeField]
    private Animator _anim;
  
    private Transform _transform; 
   
   
    private void Start()
    {

       
        _transform = GetComponent<Transform>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.tag == "Platform")
        {
            Instantiate(SoundJump);
           
            this.transform.parent = collision.transform;
           
        }
        if (collision.gameObject.tag == "Coin")
        {
            Instantiate(SoundCoin);
            Instantiate(SoundDamage);
        }
        if (collision.gameObject.tag == "Dangerous")
        {
             Instantiate(SoundDamage);
            _anim.SetBool("CollisionRedPlatform", true);

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("GameOver"))
        {
          
            _anim.SetBool("CollisionRedPlatform", true);
            Data.LifeCount--;
            Instantiate(SoundDamage);
            Singelton.instant.IsSpawn = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
       
        _anim.SetBool("CollisionRedPlatform", false);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        this.transform.parent = null;
        Instantiate(SoundMove);
        _anim.SetBool("CollisionRedPlatform", false);

    }
}
