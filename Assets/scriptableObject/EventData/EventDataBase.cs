using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventDataBase : ScriptableObject
{
    public List<EventScriptableObject> EventData = new List<EventScriptableObject>();
    public EventScriptableObject FindEvent(int a)
    {
        foreach (var item in EventData)
        {
            if (item.ID == a)
            {
                return item;
            }
        }
        return null;
    }
}
