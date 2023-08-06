using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class trigger : MonoBehaviour
{
    public int score;
    public Text text;
    public GameObject panel;
    public GameObject panelPL2;

    public gameManager GameManager;

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

            panel.SetActive(true);
            panelPL2.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            GameManager.incrementGoal();
        }
    }
}
