using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class limite : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            SceneManager.LoadScene("derrota");
        }

        if (other.gameObject.CompareTag("Player2"))
        {
            SceneManager.LoadScene("derrota");
        }
    }

}
