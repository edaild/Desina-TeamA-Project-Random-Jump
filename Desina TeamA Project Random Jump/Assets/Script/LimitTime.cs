using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{


    public float LimitTime;
    public Text Text;

    void Update()
    {
        LimitTime -= Time.deltaTime;
        Text.text = "Time : "+ Mathf.Round(LimitTime);
        
        
        if(LimitTime <= 0)
        {
            
            Debug.Log("�ð��� ���� �Ǿ����ϴ�.");
            gameObject.SetActive(false);
        }

    }
}
