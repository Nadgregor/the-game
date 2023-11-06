using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class clock : MonoBehaviour
{
    public TMP_Text text;
    void Start()
    {
        text.text = "0";
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {   
        for(int i = 0; i < 1000000; i++)
        {
            yield return new WaitForSeconds(1);
            text.text = i.ToString();
        }
       
        
    }
}
