using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class triggerPL2 : MonoBehaviour
{
    public int score;
    public Text text;
    public GameObject panel;
    public GameObject panelPL1;
    
    public gmPL2 GameManager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Score == 3)
        {  
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("VictoriaPL2");

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player2"))
        {
            GameManager.incrementGoal();
        }
    }
}
