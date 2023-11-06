using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ai : MonoBehaviour
{
    public GameObject target;
    public GameObject aii;
    public GameObject pumpkin;
    public bool check = false;
    public float x = 0;
    public float y = 0;
    void Update()
    {


        float distance = Vector3.Distance(aii.transform.position, target.transform.position);
        if (Input.GetKey(KeyCode.LeftControl))
        {
            if (distance < 100)
            {
                check = false;
                aii.transform.position = Vector3.MoveTowards(aii.transform.position, target.transform.position, Time.deltaTime * 6f);
                pumpkin.transform.LookAt(target.transform.position);
            }
            else if(check == false)
            {
                check = true;
                x = UnityEngine.Random.Range(-248.0f, 248.0f);
                y = UnityEngine.Random.Range(-248.0f, 248.0f);
            }
            else
            {
                aii.transform.position = Vector3.MoveTowards(aii.transform.position, new Vector3(x,1,y), Time.deltaTime * 6f);
                pumpkin.transform.LookAt(new Vector3(x, 1, y));
                if (new Vector3(x, 1, y) == aii.transform.position)
                {
                    check = false;
                }
            }

        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            if (distance < 30)
            {
                check = false;
                aii.transform.position = Vector3.MoveTowards(aii.transform.position, target.transform.position, Time.deltaTime * 6f);
                pumpkin.transform.LookAt(target.transform.position);
            }
            else if (check == false)
            {
                check = true;
                x = UnityEngine.Random.Range(-248.0f, 248.0f);
                y = UnityEngine.Random.Range(-248.0f, 248.0f);
            }
            else
            {
                aii.transform.position = Vector3.MoveTowards(aii.transform.position, new Vector3(x, 1, y), Time.deltaTime * 6f);
                pumpkin.transform.LookAt(new Vector3(x, 1, y));
                if (new Vector3(x, 1, y) == aii.transform.position)
                {
                    check = false;
                }
            }

        }
        else
        {
            if (distance < 50)
            {
                check = false;
                aii.transform.position = Vector3.MoveTowards(aii.transform.position, target.transform.position, Time.deltaTime * 6f);
                pumpkin.transform.LookAt(target.transform.position);
            }
            else if (check == false)
            {

                check = true;
                x = UnityEngine.Random.Range(-248.0f, 248.0f);
                y = UnityEngine.Random.Range(-248.0f, 248.0f);
            }
            else
            {
                aii.transform.position = Vector3.MoveTowards(aii.transform.position, new Vector3(x, 1, y), Time.deltaTime * 6f);
                pumpkin.transform.LookAt(new Vector3(x, 1, y));
                if (new Vector3(x,1,y) == aii.transform.position)
                {
                    check = false;
                }
            }
        }
    }
}
