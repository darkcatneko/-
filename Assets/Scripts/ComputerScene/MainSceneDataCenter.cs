using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Events;

public class MainSceneDataCenter : MonoBehaviour
{
    public int Health = 3; public Image[] HeartPics = new Image[3];
    public bool Fire;public bool Unicorn;public bool Taiwan;
    public static MainSceneDataCenter instance = new MainSceneDataCenter();
    public int Viewer = 0;public Image vtuber;
    public TextMeshProUGUI ViewerCount;
    public Gameuse mygame;

    public Animator Egganimator;public GameState State;
    public Image EventPic; public Text EventName; public Text EventDescribe;public GameObject EventBlock;public Text ViewerChange;
    public EventDataBase eventdata;
    public Image FirePic; public Image UnicornPic; public Image TaiwanPic;
    public Sprite[] Heart = new Sprite[2];
    public Sprite[] Board = new Sprite[2];
    public UnityEvent DangerEvent = new UnityEvent();
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
    public void EventTrigger()
    {
        EventScriptableObject a = GenEvent();
        if (State == GameState.FreeMove)
        {
            State = GameState.EventTrigger;
            Egganimator.SetBool("Egging", true);
            if (a.EventType == EventType.Negetive)
            {
                //反版
                EventPic.sprite = a.EventPic;
                EventName.text = a.EventName;
                EventDescribe.text = a.EventDescribe;
                Viewer = Mathf.RoundToInt( Viewer * (100-a.ChangeValue)*0.01f);
                ViewerChange.color = Color.red;
                ViewerChange.text = "-  " + a.ChangeValue.ToString() + "%";
                //生成音效
            }
            else if (a.EventType == EventType.Positive)
            {
                //正版
                EventPic.sprite = a.EventPic;
                EventName.text = a.EventName;
                EventDescribe.text = a.EventDescribe;
                Viewer += (int)a.ChangeValue;
                ViewerChange.color = Color.green;
                ViewerChange.text = "+  " + a.ChangeValue.ToString() ;               
                //生成音效
            }
            else 
            {
                //反版
                EventPic.sprite = a.EventPic;
                EventName.text = a.EventName;
                EventDescribe.text = a.EventDescribe;
                Viewer = Mathf.RoundToInt(Viewer * (100 - a.ChangeValue) * 0.01f);
                ViewerChange.color = Color.red;
                ViewerChange.text = "-  " + a.ChangeValue.ToString() + "%";
                DangerEvent.AddListener(()=> { CheckDanger(a); });
                //生成音效
            }
            EventBlock.SetActive(true);
            Invoke("eggEnd", 4f);
        }
        

    }
    public void CheckDanger(EventScriptableObject a)
    {
        if (a.Trigger == Trigger.Fire)
        {
            if (Fire == false)
            {
                Fire = true;
            }
            else
            {

            }
        }
        else if (a.Trigger == Trigger.Unicorn)
        {
            if (Unicorn == false)
            {
                Unicorn = true;
            }
            else
            {

            }
        }
         else
        {
            if (Taiwan == false)
            {
                Taiwan = true;
            }
            else
            {

            }
        }
        DangerEvent.RemoveAllListeners();
    }
    public void CloseEvent()
    {
        if (State == GameState.EventTrigger)
        {
            EventBlock.SetActive(false);
            if (DangerEvent!=null)
            {
                DangerEvent.Invoke();
            }
            State = GameState.FreeMove;
        }
    }
    public void eggEnd()
    {
        this.GetComponent<Animator>().SetBool("Egging", false);
    }
    public EventScriptableObject GenEvent()
    {
        int a = Random.Range(1, 101);
        if (a<=20)
        {
            if (a<=2)
            {
                return eventdata.FindEvent(21);
            }
            else if (a<=4)
            {
                return eventdata.FindEvent(22);
            }
            else if (a <= 6)
            {
                return eventdata.FindEvent(23);
            }
            else if (a <= 9)
            {
                return eventdata.FindEvent(24);
            }
            else if (a <= 12)
            {
                return eventdata.FindEvent(25);
            }
            else if (a <= 15)
            {
                return eventdata.FindEvent(26);
            }
            else if (a <= 17)
            {
                return eventdata.FindEvent(27);
            }
            else if (a <= 19)
            {
                return eventdata.FindEvent(28);
            }
            else 
            {
                return eventdata.FindEvent(29);
            }
        }
        else
        {
            if (a <= 24)
            {
                return eventdata.FindEvent(1);
            }
            else if (a <= 28)
            {
                return eventdata.FindEvent(2);
            }
            else if (a <= 34)
            {
                return eventdata.FindEvent(3);
            }
            else if (a <= 38)
            {
                return eventdata.FindEvent(4);
            }
            else if (a <= 42)
            {
                return eventdata.FindEvent(5);
            }
            else if (a <= 46)
            {
                return eventdata.FindEvent(6);
            }
            else if (a <= 50)
            {
                return eventdata.FindEvent(7);
            }
            else if (a <= 54)
            {
                return eventdata.FindEvent(8);
            }
            else if (a <= 58)
            {
                return eventdata.FindEvent(9);
            }
            else if (a <= 62)
            {
                return eventdata.FindEvent(10);
            }
            else if (a <= 66)
            {
                return eventdata.FindEvent(11);
            }
            else if (a <= 69)
            {
                return eventdata.FindEvent(12);
            }
            else if (a <= 73)
            {
                return eventdata.FindEvent(13);
            }
            else if (a <= 77)
            {
                return eventdata.FindEvent(14);
            }
            else if (a <= 82)
            {
                return eventdata.FindEvent(15);
            }
            else if (a <= 84)
            {
                return eventdata.FindEvent(16);
            }
            else if (a <= 86)
            {
                return eventdata.FindEvent(17);
            }
            else if (a <= 91)
            {
                return eventdata.FindEvent(18);
            }
            else if (a <= 96)
            {
                return eventdata.FindEvent(19);
            }
            else
            {
                return eventdata.FindEvent(20);
            }
        }
    }
}
[System.Serializable]
public enum GameState
{
    EventTrigger,
    FreeMove,
}
