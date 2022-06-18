using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewUniverse", menuName = "NewUniverse")]
public class Universe : ScriptableObject
{
    public int ID;
    public AudioClip Sound;
    [TextArea(15, 20)]
    public string UniverseName;
    [TextArea(15, 20)]
    public string UniverseDescribe;
    public Sprite UniversePic;
}
