using System.Collections;
using System.Collections.Generic;
using System.Drawing.Printing;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject GameoverText;

    private bool isGameover;
    
    void Start()
    {
        isGameover = false;
    }

    
    void Update()
    {
        if (isGameover)
        {
            isGameover = true;
            GameoverText.SetActive(true);
        }
    }
}
