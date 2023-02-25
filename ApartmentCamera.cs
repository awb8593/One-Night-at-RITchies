using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apartment : MonoBehaviour
{
    void Update()
    {
        float rotateHorizontal = Input.GetAxis ("Mouse X");
        if (rotateHorizontal > 120) {
            rotateHorizontal = 120;
        }
        if (rotateHorizontal < -120) {
            rotateHorizontal = -120
        }
    }
}
