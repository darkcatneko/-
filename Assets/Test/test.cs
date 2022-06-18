using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject ball;
    public Transform spawnpoint;
    public void Buttontest()
    {
        Debug.Log(1);
    }
    public void genball()
    {
        Instantiate(ball, spawnpoint.position, Quaternion.identity);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            genball();
        }
    }
}

