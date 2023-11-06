using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class playsus : MonoBehaviour
{
    public GameObject ai;
    AudioSource audioData;
    void Start()
    {
        StartCoroutine(Example());
    }
    IEnumerator Example()
    {
        for (int i = 0; i < 100; i++)
        {
            Debug.Log("dupa");
            yield return new WaitForSeconds(UnityEngine.Random.Range(10, 20));
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
            GameObject tree = GameObject.Instantiate(ai);
            tree.transform.position = new Vector3(UnityEngine.Random.Range(-248.0f, 248.0f), 0, UnityEngine.Random.Range(-248.0f, 248.0f));
        }
       
    }
  
}
