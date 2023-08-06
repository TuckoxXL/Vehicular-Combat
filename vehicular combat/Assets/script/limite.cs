using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class limite : MonoBehaviour
{
    public GameObject canvasVictoria;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            Debug.Log("dale");
            canvasVictoria.SetActive(true);
            Time.timeScale = 0;
        }

        if (other.gameObject.CompareTag("Player2"))
        {
            SceneManager.LoadScene("derrota");
        }
    }

}
