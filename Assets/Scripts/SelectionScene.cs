using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SelectionScene : MonoBehaviour
{
    public Gameuse gameuse;
    public Universe This_universe;
    public UniverseData U_Data;
    public Image UniversePic;
    public Text UniverseName;
    public Text Describtion;
    public AudioSource Sound;
    void Start()
    {
        int a;
        a = Random.Range(0, 7);
        This_universe = U_Data.FindUniverse(a);
        Invoke("GenSound", 1f); 
        UniversePic.sprite = This_universe.UniversePic;
        UniverseName.text = This_universe.UniverseName;
        Describtion.text = This_universe.UniverseDescribe;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GenSound()
    {
        //Sound.clip = This_universe.Sound;
        Sound.PlayOneShot(This_universe.Sound);
    }
    public void Choose()
    {
        gameuse.myUniverse = This_universe;
        SceneManager.LoadScene("ComputerScene");
    }
}
