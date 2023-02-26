using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SwitchCams : MonoBehaviour
{
    public RawImage currentCam;
    private RawImage img;

    public Material gracies;
    public Material nature;
    public Material gordon;
    public Material gpc;
    public Material shed;
    public Material sau;
    public Material tigerStatue;
    public Material kgcoe;
    public Material globalVillage;
    public Material golisano;
    public Material hallway;

    void Start()
    {
        img = (RawImage)currentCam.GetComponent<RawImage>();
        currentCam.material = gracies;
    }

    public void switchGracies() 
    {
        currentCam.material = gracies;
        Debug.Log("Gracies!");
    }

    public void switchNature()
    {
        currentCam.material = nature;
        Debug.Log("Nature!");
    }

    public void switchGordon() 
    {
        currentCam.material = gordon;
    }

    public void switchGPC() 
    {
        currentCam.material = gpc;
    }

    public void switchSHED() 
    {
        currentCam.material = shed;
    }

    public void switchSAU() 
    {
        currentCam.material = sau;
    }

    public void switchTigerStatue() 
    {
        currentCam.material = tigerStatue;
    }

    public void switchKGCOE() 
    {
        currentCam.material = kgcoe;
    }

    public void switchGlobalVillage() 
    {
        currentCam.material = globalVillage;
    }

    public void switchGolisano() 
    {
        currentCam.material = golisano;
    }

    public void switchHallway() 
    {
        currentCam.material = hallway;
    }
}
