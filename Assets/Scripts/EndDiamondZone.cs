using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndDiamondZone : MonoBehaviour
{
    public Text gameOverText;
    private bool canRestart = false;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If player has reached the end give them an option to restart
        if (canRestart)
        {
            if (Input.GetKeyDown(KeyCode.R)) {
                SceneManager.LoadScene("Level01");
            }
        }
    }

    void  OnTriggerEnter(Collider other)
    {   
        // If player collides with diamond end display a winning text and change canRestart to true
        if(other.tag == "Player")
        {
            canRestart = true;
            gameOverText.color = new Color(0, 0, 0, 1);
            gameOverText.text = "You Win! \n\n\nPress 'r' to reset";
        }
    }


}
