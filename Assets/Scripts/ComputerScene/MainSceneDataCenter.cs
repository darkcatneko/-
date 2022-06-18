using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MainSceneDataCenter : MonoBehaviour
{
    public static MainSceneDataCenter instance = new MainSceneDataCenter();
    public int Viewer = 0;public Image vtuber;
    public TextMeshProUGUI ViewerCount;
    public Gameuse mygame;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        vtuber.sprite = mygame.myUniverse.UniversePic;
    }

    // Update is called once per frame
    void Update()
    {
        ViewerCount.text = Viewer.ToString();
    }
}
