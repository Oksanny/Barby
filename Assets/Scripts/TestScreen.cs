using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScreen : MonoBehaviour
{
    public float horizontalFoV = 90.0f;
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float halfWidth = Mathf.Tan(0.5f * horizontalFoV * Mathf.Deg2Rad);

        float halfHeight = halfWidth * Screen.height / Screen.width;

        float verticalFoV = 2.0f * Mathf.Atan(halfHeight) * Mathf.Rad2Deg;
        
        camera.fieldOfView = verticalFoV;
    }
}
