using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewUniverse", menuName = "NewUniverseData")]
public class UniverseData : ScriptableObject
{
    public List<Universe> m_UniverseData = new List<Universe>();
    public Universe FindUniverse(int a)
    {
        foreach (var item in m_UniverseData)
        {
            if (item.ID == a)
            {
                return item;
            }
        }
        return null;
    }   
}
