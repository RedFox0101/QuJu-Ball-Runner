using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSpawn : MonoBehaviour
{

  
    private float y_min, y_max;
   

    public void SetPosition(float Y_min, float Y_max)
    {
        y_min = Y_min;
        y_max = Y_max;
        transform.position = new Vector2(Random.Range(Singelton.instant.CamMin.x, Singelton.instant.CamMax.x), Random.Range(Y_min, Y_max));
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag=="Platform")
        {
            Debug.Log("Respawn");
            SetPosition(y_min, y_max);
            
        }
    }
}
