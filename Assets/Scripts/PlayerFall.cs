using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If player falls to low on the y positino restart the level
        if (transform.position.y < -100)
        {
            SceneManager.LoadScene("Level01");
        }
    }
}
