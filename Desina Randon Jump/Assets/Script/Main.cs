using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Main : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            SceneManager.LoadScene("GameScene");
        }

        if (Input.GetKey(KeyCode.E))
        {
            // UnityEditor.EditorApplication.isPlaying = false;
            // Application.Quit();
           
        }
    }



}
