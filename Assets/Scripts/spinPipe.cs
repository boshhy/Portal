using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinPipe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update () {
        // this is used to rotate the pipe
		    transform.Rotate(60f * Time.deltaTime, 0f, 0f, Space.Self);      
	}
}
