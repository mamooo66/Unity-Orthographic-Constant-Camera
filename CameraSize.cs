using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSize : MonoBehaviour
{
    public float targetAspect;
    private void Start() {
        // initialSize is the default Camera.main.orthographicSize
        // targetAspect is the desired aspect ratio

        float initialSize = Camera.main.orthographicSize;

        if (Camera.main.aspect < 1.6f)
        {
            // respect width (modify default behavior)
            Camera.main.orthographicSize = initialSize * (targetAspect / Camera.main.aspect);
        }
        else
        {
            // respect height (change back to default behavior)
            Camera.main.orthographicSize = initialSize;
        }
    }
}
