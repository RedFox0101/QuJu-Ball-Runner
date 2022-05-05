using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private Transform _transform;
    private float speed;
    private Vector2 CamMin, CamMax;
    [SerializeField]
    private float _horizontalSpeed;

    public Transform[] _posSpawn;

    private int _pos = 1;
    [SerializeField]
    private float _lineDistans;

    public int Index;


    private void Start()
    {

        if (Index == PlayerPrefs.GetInt("BallIndex"))
        {
            EventHolder.PlayerAction(this.GetComponent<Player>());
        }
        else
        {
            Destroy(gameObject);
        }
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _transform = GetComponent<Transform>();

        CamMin = Singelton.instant.CamMin;
        CamMax = Singelton.instant.CamMax;
    }

    private void Update()
    {
        if (transform.position.x < CamMin.x)
        {

            transform.position = new Vector3(CamMax.x - 0.2f, transform.position.y, transform.position.z);
        }
        if (transform.position.x > CamMax.x)
        {

            transform.position = new Vector3(CamMin.x + 0.2f, transform.position.y, transform.position.z);
        }
#if UNITY_EDITOR
        if (Input.GetKey(KeyCode.D))
        {
            if (_pos < 2)
            {
                _pos++;
                Move(_pos);
            }
                
            
        }
       if (Input.GetKey(KeyCode.A))
        {

            if (_pos > 0)
            {
                _pos--;
                Move(_pos);
            }
        }
        
#endif

    }

    private void FixedUpdate()
    {

        transform.Translate(speed, 0, 0);
    }

    public void Move(int index)
    {


        _pos += index;
            _transform.position =new Vector2(_posSpawn[_pos].position.x, _transform.position.y);
            
        


        //speed = _horizontalSpeed * index;
        //if (speed > 0)
        //{
        //    _spriteRenderer.flipX = true;
        //}

        //else if (speed < 0)
        //{
        //    _spriteRenderer.flipX = false;
        //}


    }

}
