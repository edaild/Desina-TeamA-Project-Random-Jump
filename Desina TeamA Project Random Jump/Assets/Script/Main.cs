using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Main : MonoBehaviour
{

    public void OnButtonClicked()
    {
        SceneManager.LoadScene("GameScene");
    }
}
