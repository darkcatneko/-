using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneDataCenter : MonoBehaviour
{
    public static MainSceneDataCenter instance = new MainSceneDataCenter();
    public int Viewer = 0;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
