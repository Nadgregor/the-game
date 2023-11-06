using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class generate : MonoBehaviour
{
    AudioSource audioData;
    public GameObject pine1;
    public GameObject pine2;
    public GameObject pine3;
    public GameObject pine4;
    public GameObject pine5;
    public GameObject pine6;
    public GameObject tree1;
    public GameObject tree2;
    public GameObject PlantFlower;
 
    void Start()
    {
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
        gen(pine1, 300);
        gen(pine2, 400);
        gen(pine3, 200);
        gen(pine4, 200);
        gen(pine5, 400);
        gen(pine6, 200);
        gen(tree1, 500);
        gen(tree2, 400);
        gen(PlantFlower, 3000);
        


    }
    private void gen(GameObject obiekt, int x)
    {
        int i = 0;
        for (i = 0; i < x; i++)
        {
            GameObject tree = GameObject.Instantiate(obiekt);
            tree.transform.position = new Vector3(UnityEngine.Random.Range(-248.0f, 248.0f),0, UnityEngine.Random.Range(-248.0f, 248.0f));
        }
    }

}
