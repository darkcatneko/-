using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
public class FirstScene : MonoBehaviour
{
    public GameObject Director;
    public GameObject Transition;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            Director.GetComponent<PlayableDirector>().enabled = true;
        }
    }
    public void PlayBlack()
    {
        Instantiate(Transition);
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
