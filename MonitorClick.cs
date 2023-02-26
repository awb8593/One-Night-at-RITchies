using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonitorClick : MonoBehaviour
{
    public GameObject room;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // hide the monitor
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100f)){
                // the monitor was clicked; hide the room
                Debug.Log("MONITOR CLICKED!");
                room.GetComponent<Renderer>().enabled = false;
            }
        }

        // bring back the room when monitor is right-clicked
        if (Input.GetMouseButtonDown(1)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100f)){
                // the object identified was clicked; hide the room
                Debug.Log("MONITOR CLICKED!");
                room.GetComponent<Renderer>().enabled = true;
            }
        }
    }
}