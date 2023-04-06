using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinDiamond : MonoBehaviour
{
    // Start is called before the first frame update
    float top = 1;
    float current = 0.5f;
    float bottom = 0;
    public float movementSpeed = 0.1f;

    Vector3 tempPos;

    void Start()
    {
        tempPos = transform.position;
    }

    // Update is called once per frame
    void Update () {
        // Rotate the end diamond
		transform.Rotate(0f, 120f * Time.deltaTime, 0f, Space.Self);      

	}
}
