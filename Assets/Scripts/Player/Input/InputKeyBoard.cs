using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKeyBoard : MonoBehaviour, IInput
{
    public Vector2 GetDirection()
    {
        if (Input.GetKey(KeyCode.A))
        {
            return Vector2.left;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            return Vector2.right;
        }
        else
        {
            return Vector2.zero;
        }
    }
}
