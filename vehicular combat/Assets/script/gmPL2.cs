using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class gmPL2 : MonoBehaviour
{
    public int Score;
    public Text text;
    public static gmPL2 instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {

    }
 
    public void incrementGoal()
    {
        Score++;
        text.text = "" + Score;
    }
}
