using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SwitchCams : MonoBehaviour
{
    public RawImage currentCam;
    private RawImage img;

    public Material cam1;
    public Material cam2;

    // Start is called before the first frame update
    void Start()
    {
        img = (RawImage)currentCam.GetComponent<RawImage>();
        currentCam.material = cam1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void switchCam1() 
    {
        currentCam.material = cam1;
    }

    public void switchCam2()
    {
        currentCam.material = cam2;
    }
}
