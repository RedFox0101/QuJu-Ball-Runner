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





    public int Index;

    private void Awake()
    {
        if (Index == PlayerPrefs.GetInt("BallIndex"))
        {
            Singelton.instant.Player = this.GetComponent<Player>();
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {


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
        if (Input.GetKey(KeyCode.A))
        {
            Move(-1);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Move(1);
        }
        else
        {
            Move(0);
        }
#endif

    }

    private void FixedUpdate()
    {

        transform.Translate(speed, 0, 0);
    }

    public void Move(int index)
    {


        speed = _horizontalSpeed * index;
        if (speed > 0)
        {
            _spriteRenderer.flipX = true;
        }

        else if (speed < 0)
        {
            _spriteRenderer.flipX = false;
        }


    }

}
