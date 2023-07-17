using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public int Score;
    public Text text;
    public static gameManager instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        
    }
    public void Win()
    {
        SceneManager.LoadScene(2);
    }
    
    public void incrementGoal()
    {
        Score++;
        text.text = "" + Score;
    }
}
