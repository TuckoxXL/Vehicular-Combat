using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class trigger : MonoBehaviour
{
    public int score;
    public Text text;

    public gameManager GameManager;
    public gmPL2 gmPL2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Score == 3)
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("VictoriaPL1");
        }

        if (gmPL2.Score == 3)
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("VictoriaPL2");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            GameManager.incrementGoal();
        }

        if (other.gameObject.CompareTag("Player2"))
        {
            gmPL2.incrementGoal();
        }
    }


}
