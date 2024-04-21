using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LimitTime : MonoBehaviour
{


    public float GameTime;
    public Text Text;

    void Update()
    {
        GameTime -= Time.deltaTime;
        Text.text = "Time : "+ Mathf.Round(GameTime);
        
        
        if(GameTime <= 0)
        {
        
            Debug.Log("�ð��� ���� �Ǿ����ϴ�.");
            gameObject.SetActive(false);
        }

    }

}
