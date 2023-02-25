using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApartmentCamera : MonoBehaviour
{
    public float maxX;
    public float minX;
    public float rightSpeed;
    public float leftSpeed;

    void Update()
    {
        bool right = Input.GetKey (KeyCode.RightArrow);
        bool left = Input.GetKey (KeyCode.LeftArrow);
        
        if (right & transform.localEulerAngles.y < maxX) {
            transform.RotateAround(this.transform.position, Vector3.up, rightSpeed * Time.deltaTime);
        }

        if (left & transform.localEulerAngles.y > maxX) {
            transform.RotateAround(this.transform.position, Vector3.up, leftSpeed * Time.deltaTime);
        }

        /**
        float rotateHorizontal = Input.GetAxis ("Mouse X");
        if (rotateHorizontal > maxX) {
            rotateHorizontal = maxX;
        }
        if (rotateHorizontal < minX) {
            rotateHorizontal = minX;
        }
        */
    }
}
