using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Bonus : MonoBehaviour
{
    public GameObject Particall;
 
    [SerializeField]
    private EffectBonus _bonusEffect;
  
    protected void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
         
            _bonusEffect.Effect();
           
            DestroyBonus();
          
        }
    }


  

    private void DestroyBonus()
    {
        Instantiate(Particall, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
