using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{   
    #region Attributes

    public Transform door;

    public Vector3 closedPosition = new Vector3(183, 8, 6);
    public Vector3 openedPosition = new Vector3(183, 14, 6);

    public float openSpeed = 5;

    private bool open = false;
    
    #endregion

    #region Monobehavior API

    void Update()
    {
        // Open the door if open is true
        if (open)
        {
            door.position = Vector3.Lerp(door.position, openedPosition, Time.deltaTime * openSpeed);
        }
        // Close the door if open is false
        // else
        // {
        //     door.position = Vector3.Lerp(door.position, closedPosition, Time.deltaTime * openSpeed);
        // }
    }

    private void OnTriggerEnter(Collider other)
    {   
        // If player collides with the button trigger, open door
        if (other.tag == "Player")
        {
            OpenDoor();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // If player leaves the button trigger, close door
        if (other.tag == "Player")
        {
            CloseDoor();
        }
    }

    #endregion

    public void CloseDoor()
    {  
        open = false;
    }

    public void OpenDoor()
    {
        open = true;
    }
}
