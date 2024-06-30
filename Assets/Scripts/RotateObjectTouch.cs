using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectTouch : MonoBehaviour
{
    
    private Vector3 lastMousePosition;
    private float rotateSpeed = 10f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastMousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {       
            Vector3 delta = Input.mousePosition - lastMousePosition;
            transform.Rotate(Vector3.up, -delta.x * rotateSpeed * Time.fixedDeltaTime);
            lastMousePosition = Input.mousePosition;
        }
    }
}
