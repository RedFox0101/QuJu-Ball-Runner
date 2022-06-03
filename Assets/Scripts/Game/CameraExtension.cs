using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CameraExtension
{
    public static (float, float) GetEdgeCamera(this Camera camera)
    {
        var leftEdge = camera.ViewportToWorldPoint(new Vector2(0, 0));
        var rightEdge = camera.ViewportToWorldPoint(new Vector2(1, 1));
        return (leftEdge.x, rightEdge.x);
    }
}
