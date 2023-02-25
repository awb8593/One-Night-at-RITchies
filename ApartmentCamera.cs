using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApartmentCamera : MonoBehaviour
{
    public float maxX;
    public float minX;
    public float moveSpeed;

    void Update()
    {
        if (Input.GetAxis("Mouse X") != 0) {
            transform.position += new Vector3 (Input.GetAxisRaw("Mouse X") * Time.deltaTime * moveSpeed, 0.0f, 0.0f);
        }

        transform.position = new Vector3 (Mathf.Clamp(transform.position.x, minX, maxX), transform.position.y, transform.position.z);
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
