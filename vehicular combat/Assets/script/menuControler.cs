using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuControler : MonoBehaviour
{
    public GameObject menuPausa;
    public bool pausa = false;

    public void Start()
    {
       
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausa == false)
            {
                menuPausa.SetActive(true);
                pausa = true;
                Time.timeScale = 0;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }

    public void Resumir()
    {
        menuPausa.SetActive(false);
        pausa = false;
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
  
}