using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconInteract : MonoBehaviour
{
    [SerializeField]public GameObject thisButton;
    public void m_OnMouseEnter()
    {
        thisButton.SetActive(true);
    }
    public void m_OnMouseExit()
    {
        thisButton.SetActive(false);
    }
    public void FireButton()
    {
        if (MainSceneDataCenter.instance.Fire ==true)
        {
            MainSceneDataCenter.instance.Viewer = Mathf.RoundToInt(MainSceneDataCenter.instance.Viewer * 0.6f);
            MainSceneDataCenter.instance.Fire = false;
            MainSceneDataCenter.instance.Icons[0].color = new Color(1, 1, 1, 0.5f);
            MainSceneDataCenter.instance.Health--;
        }
    }
    public void UnicornButton()
    {
        if (MainSceneDataCenter.instance.Unicorn == true)
        {
            MainSceneDataCenter.instance.Viewer = Mathf.RoundToInt(MainSceneDataCenter.instance.Viewer * 0.6f);
            MainSceneDataCenter.instance.Unicorn = false;
            MainSceneDataCenter.instance.Icons[1].color = new Color(1, 1, 1, 0.5f);
            MainSceneDataCenter.instance.Health--;
        }
    }
    public void TaiwanButton()
    {
        if (MainSceneDataCenter.instance.Taiwan == true)
        {
            MainSceneDataCenter.instance.Viewer = Mathf.RoundToInt(MainSceneDataCenter.instance.Viewer * 0.6f);
            MainSceneDataCenter.instance.Icons[2].color = new Color(1, 1, 1, 0.5f);
            MainSceneDataCenter.instance.Taiwan = false;
            MainSceneDataCenter.instance.Health--;
        }
    }
}
