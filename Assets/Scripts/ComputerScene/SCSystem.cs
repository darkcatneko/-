using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCSystem : MonoBehaviour
{
    public GameObject Chats;
    [SerializeField] public Queue ChatList = new Queue();
    void Start()
    {
        InvokeRepeating("GenSc", 2f, 5f);
        
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            MainSceneDataCenter.instance.Viewer +=1000;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine("RainBowSC");
        }
        
    }
    public IEnumerator RainBowSC()
    {
        for (int i = 0; i < 7; i++)
        {
            ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/RainBow_" + i.ToString()), Chats.transform));
            if (ChatList.Count > 20)
            {
                Destroy((GameObject)ChatList.Dequeue());
            }
            yield return new WaitForSeconds(0.2f);
        }
    }
    public void GenSc()
    {
        var m_viewer = MainSceneDataCenter.instance.Viewer;
        if (m_viewer>=0&&m_viewer<=100)//¥Õ
        {
            CancelInvoke();
            InvokeRepeating("GenSc", 2f, 5f);
            int a = Random.Range(1, 6);
            ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_White_"+a.ToString()),Chats.transform));
            if (ChatList.Count>20)
            {
                Destroy((GameObject)ChatList.Dequeue());
            }
        }
        else if (m_viewer > 100 && m_viewer <= 500)//ÂÅ
        {
            CancelInvoke();
            InvokeRepeating("GenSc", 2f, 5f);
            int sc_chance = Random.Range(1, 100);
            int a;
            if (sc_chance<=5)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_Blue_" + a.ToString()), Chats.transform));
            }
            else
            {
                a = Random.Range(1, 6);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_White_" + a.ToString()), Chats.transform));
            }            
            if (ChatList.Count > 20)
            {
                Destroy((GameObject)ChatList.Dequeue());
            }
        }
        else if (m_viewer > 500 && m_viewer <= 1000)//ºñÂÅ
        {
            CancelInvoke();
            InvokeRepeating("GenSc", 1f, 2.5f);
            int sc_chance = Random.Range(1, 100);
            int a;
            if (sc_chance <= 10)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_Blue_" + a.ToString()), Chats.transform));
            }
            else if(sc_chance <= 20)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_MikuBlue_" + a.ToString()), Chats.transform));
            }
            else
            {
                a = Random.Range(1, 6);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_White_" + a.ToString()), Chats.transform));
            }
            if (ChatList.Count > 20)
            {
                Destroy((GameObject)ChatList.Dequeue());
            }
        }
        else if (m_viewer > 1000 && m_viewer <= 10000)//«Cºñ
        {
            CancelInvoke();
            InvokeRepeating("GenSc", 1f, 1.5f);
            int sc_chance = Random.Range(1, 100);
            int a;
            if (sc_chance <= 20)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_Blue_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 35)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_MikuBlue_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 40)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_GreenBlue_" + a.ToString()), Chats.transform));
            }
            else
            {
                a = Random.Range(1, 6);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_White_" + a.ToString()), Chats.transform));
            }
            if (ChatList.Count > 20)
            {
                Destroy((GameObject)ChatList.Dequeue());
            }
        }
        else if (m_viewer > 10000 && m_viewer <= 30000)//¾ï¶À
        {
            CancelInvoke();
            InvokeRepeating("GenSc", 1f, 1f);
            int sc_chance = Random.Range(1, 100);
            int a;
            if (sc_chance <= 20)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_Blue_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 40)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_MikuBlue_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 50)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_GreenBlue_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 60)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_YellowOrange_" + a.ToString()), Chats.transform));
            }
            else
            {
                a = Random.Range(1, 6);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_White_" + a.ToString()), Chats.transform));
            }
            if (ChatList.Count > 20)
            {
                Destroy((GameObject)ChatList.Dequeue());
            }
        }
        else if (m_viewer > 30000 && m_viewer <= 50000)//¾ï¬õ
        {
            CancelInvoke();
            InvokeRepeating("GenSc", 0.3f, 0.5f);
            int sc_chance = Random.Range(1, 100);
            int a;
            if (sc_chance <= 20)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_Blue_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 35)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_MikuBlue_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 45)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_GreenBlue_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 55)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_YellowOrange_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 60)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_Orange_" + a.ToString()), Chats.transform));
            }
            else
            {
                a = Random.Range(1, 6);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_White_" + a.ToString()), Chats.transform));
            }
            if (ChatList.Count > 20)
            {
                Destroy((GameObject)ChatList.Dequeue());
            }
        }
        else if (m_viewer > 50000 && m_viewer <= 75000)//µµ¬õ
        {
            CancelInvoke();
            InvokeRepeating("GenSc", 0.2f, 0.25f);
            int sc_chance = Random.Range(1, 100);
            int a;
            if (sc_chance <= 20)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_Blue_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 40)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_MikuBlue_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 50)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_GreenBlue_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 60)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_YellowOrange_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 65)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_Orange_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 70)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_Purple_" + a.ToString()), Chats.transform));
            }
            else
            {
                a = Random.Range(1, 6);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_White_" + a.ToString()), Chats.transform));
            }
            if (ChatList.Count > 20)
            {
                Destroy((GameObject)ChatList.Dequeue());
            }
        }
        else if (m_viewer > 75000 && m_viewer <= 100000)//¬õ
        {
            CancelInvoke();
            InvokeRepeating("GenSc", 0.1f, 0.15f);
            int sc_chance = Random.Range(1, 100);
            int a;
            if (sc_chance <= 20)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_Blue_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 40)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_MikuBlue_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 50)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_GreenBlue_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 60)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_YellowOrange_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 70)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_Orange_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 75)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_Purple_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 80)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_Red_" + a.ToString()), Chats.transform));
            }
            else
            {
                a = Random.Range(1, 6);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_White_" + a.ToString()), Chats.transform));
            }
            if (ChatList.Count > 20)
            {
                Destroy((GameObject)ChatList.Dequeue());
            }
        }
        else if (m_viewer > 100000 && m_viewer <= 500000)//¬õ
        {
            CancelInvoke();
            InvokeRepeating("GenSc", 0.1f, 0.15f);
            int sc_chance = Random.Range(1, 100);
            int a;
            
            if (sc_chance <= 20)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_MikuBlue_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 40)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_GreenBlue_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 60)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_YellowOrange_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 70)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_Orange_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 80)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_Purple_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 90)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_Red_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 95)
            {
                StartCoroutine("RainBowSC");
            }
            else
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_Blue_" + a.ToString()), Chats.transform));
            }
            if (ChatList.Count > 20)
            {
                Destroy((GameObject)ChatList.Dequeue());
            }
        }
        else
        {
            CancelInvoke();
            InvokeRepeating("GenSc", 0.1f, 0.15f);
            int sc_chance = Random.Range(1, 100);
            int a;

            if (sc_chance <= 10)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_MikuBlue_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 20)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_GreenBlue_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 30)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_YellowOrange_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 50)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_Orange_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 70)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_Purple_" + a.ToString()), Chats.transform));
            }
            else if (sc_chance <= 90)
            {
                a = Random.Range(1, 3);
                ChatList.Enqueue(Instantiate(Resources.Load<GameObject>("SC/SC_Red_" + a.ToString()), Chats.transform));
            }
            else 
            {
                StartCoroutine("RainBowSC");
            }           
            if (ChatList.Count > 20)
            {
                Destroy((GameObject)ChatList.Dequeue());
            }
        }
    }
}
