using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAdd : MonoBehaviour
{
    [SerializeField]
    private List<Sprite> _sprite;
    private SpriteRenderer _spriteRenderer;
   

    private void Start()
    {
       
        _spriteRenderer = this.GetComponent<SpriteRenderer>();
       
            _spriteRenderer.sprite = _sprite[Random.Range(0, _sprite.Count)];
        
    }
}
