using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMove :IMove
{
   
    private Vector3 vector;
    private Move _platform;
    private float _buffSpeed, _speedX, _camMin, _camMax;

    public HorizontalMove(Move platform)
    {
        _speedX = Singelton.instant.speed;

        _buffSpeed = Singelton.instant.speed;
        _camMin = Singelton.instant.CamMin.x;
        _camMax = Singelton.instant.CamMax.x;
        _platform = platform;
    }

   
    public Vector3 Move()
    {
        if (_platform.transform.position.x < _camMin)
        {
            _speedX = _buffSpeed;
        }

        if (_platform.transform.position.x > _camMax - 1.5f)
        {
            _speedX = -_buffSpeed;

        }

        vector = new Vector3(_speedX, 0);
        
        return vector;
    }
}
