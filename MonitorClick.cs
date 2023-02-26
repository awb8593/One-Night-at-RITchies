using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonitorClick : MonoBehaviour
{
    public GameObject room;
    public GameObject cameras;
    public GameObject officeUI;
    bool camerasUp;

    // Start is called before the first frame update
    void Start()
    {
        officeUI.SetActive(true);
        cameras.SetActive(false);
        camerasUp = false;
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
                room.GetComponent<Renderer>().enabled = false;
                cameras.SetActive(true);
                officeUI.SetActive(false);
                camerasUp = true;
                Debug.Log("camerusUp: " + camerasUp);
            }
        }

        // bring back the room when monitor is right-clicked
        if (Input.GetKey(KeyCode.S) && camerasUp == true) {
            
            // the object identified was clicked; hide the room
            cameras.SetActive(false);
            officeUI.SetActive(true);
            room.GetComponent<Renderer>().enabled = true;
            camerasUp = false;
            Debug.Log("camerusUp: " + camerasUp);
        }
    }
}