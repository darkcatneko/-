using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewEvent", menuName = "Event")]
public class EventScriptableObject :ScriptableObject
{
    public int ID;
    public EventType EventType;
    public Trigger Trigger;
    public float ChangeValue;
    public Sprite EventPic;
    public float Chance;    
    [TextArea(15, 20)]
    public string EventName;
    [TextArea(15, 20)]
    public string EventDescribe;
}
[System.Serializable]
public enum EventType
{
    Positive,
    Negetive,
}
[System.Serializable]
public enum Trigger
{
    Fire,
    Taiwan,
    Unicorn,
}
