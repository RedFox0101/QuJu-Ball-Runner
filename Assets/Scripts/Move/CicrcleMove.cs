using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CicrcleMove : MonoBehaviour
{
    [SerializeField]
    private Transform _center;
    private Transform _transform;
    [SerializeField]
    private float _radius, _angularSpeed;

    private float _positionX, _positionY, _angle = 0;
    private void Start()
    {
       
         _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        _positionX = _center.position.x + Mathf.Cos(_angle) * _radius;
        _positionY = _center.position.y + Mathf.Sin(_angle) * _radius;
        _transform.position = new Vector2(_positionX, _positionY);

        _angle += Time.deltaTime * _angularSpeed;

        if (_angle >= 360)
        {
            _angle = 0;
        }
    }
}
