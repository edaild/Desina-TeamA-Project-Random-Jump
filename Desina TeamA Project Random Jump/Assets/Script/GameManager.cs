using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        
    }

    public void EndGame()
    {
        isGameover = true;
        GameoverText.SetActive(true);

    }
}
