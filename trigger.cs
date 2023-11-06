using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class trigger: MonoBehaviour
{
    public GameObject pumpkin;
    AudioSource audioData;
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player")) {
            StartCoroutine(Example());



        }
    }
    IEnumerator Example()
    {
        
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
        pumpkin.SetActive(true);
        yield return new WaitForSeconds(4);
        Cursor.visible = true;
        SceneManager.LoadScene("play");
    }
    }

    
