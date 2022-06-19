using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Events;

public class MainSceneDataCenter : MonoBehaviour
{
    public int Health = 3; public Image[] HeartPics = new Image[3]; public Image[] Icons = new Image[3];
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

    public GameObject EndBoard; public Image EndPic;public Text EndString;public Text EndViewer;public Image Rate;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        vtuber.sprite = mygame.myUniverse.UniversePic;
        State = GameState.FreeMove;
    }

    // Update is called once per frame
    void Update()
    {
        ViewerCount.text = Viewer.ToString();
        HeartCheck();
    }
    public void EventTriggerButton()
    {
        StartCoroutine("EventTrigger");
    }
    public IEnumerator EventTrigger()
    {
        EventScriptableObject a = GenEvent();
        if (State == GameState.FreeMove)
        {
            State = GameState.EventTrigger;
            Egganimator.SetBool("Egging", true);
            yield return new WaitForSeconds(4f);
            if (a.EventType == EventType.Negetive)
            {
                GameObject se = Instantiate(Resources.Load<GameObject>("Bruh"));
                EventBlock.GetComponent<Image>().sprite = Board[1];
                EventPic.sprite = a.EventPic;
                EventName.text = a.EventName;
                EventDescribe.text = a.EventDescribe;
                Viewer = Mathf.RoundToInt( Viewer * (100-a.ChangeValue)*0.01f);
                ViewerChange.color = Color.red;
                ViewerChange.text = "-  " + a.ChangeValue.ToString() + "%";
                //�ͦ�����
            }
            else if (a.EventType == EventType.Positive)
            {
                int b;
                b = Random.Range(1, 4);
                GameObject se = Instantiate(Resources.Load<GameObject>("Positive_" + b.ToString()));
                EventBlock.GetComponent<Image>().sprite = Board[0];
                EventPic.sprite = a.EventPic;
                EventName.text = a.EventName;
                EventDescribe.text = a.EventDescribe;
                Viewer += (int)a.ChangeValue;
                ViewerChange.color = Color.green;
                ViewerChange.text = "+  " + a.ChangeValue.ToString() ;               
                //�ͦ�����
            }
            else 
            {
                GameObject se = Instantiate(Resources.Load<GameObject>("Bruh"));
                EventBlock.GetComponent<Image>().sprite = Board[1];
                EventPic.sprite = a.EventPic;
                EventName.text = a.EventName;
                EventDescribe.text = a.EventDescribe;
                Viewer = Mathf.RoundToInt(Viewer * (100 - a.ChangeValue) * 0.01f);
                ViewerChange.color = Color.red;
                ViewerChange.text = "-  " + a.ChangeValue.ToString() + "%";
                DangerEvent.AddListener(()=> { CheckDanger(a); });
                //�ͦ�����
            }
            EventBlock.SetActive(true);
            eggEnd();
        }
        

    }
    public void HeartCheck()
    {
        switch(Health)
        {
            case 0:
                HeartPics[0].sprite = Heart[0];
                HeartPics[1].sprite = Heart[0];
                HeartPics[2].sprite = Heart[0];
                EndGame();
                return;
            case 1:
                HeartPics[0].sprite = Heart[1];
                HeartPics[1].sprite = Heart[0];
                HeartPics[2].sprite = Heart[0];
                return;
            case 2:
                HeartPics[0].sprite = Heart[1];
                HeartPics[1].sprite = Heart[1];
                HeartPics[2].sprite = Heart[0];
                return;
            case 3:
                HeartPics[0].sprite = Heart[1];
                HeartPics[1].sprite = Heart[1];
                HeartPics[2].sprite = Heart[1];
                return;
        }
    }
    public void CheckDanger(EventScriptableObject a)
    {
        if (a.Trigger == Trigger.Fire)
        {
            if (Fire == false)
            {
                Fire = true;
                Icons[0].color = new Color(1, 1, 1, 1);
            }
            else
            {
                EndGame();
            }
        }
        else if (a.Trigger == Trigger.Unicorn)
        {
            if (Unicorn == false)
            {
                Unicorn = true;
                Icons[1].color = new Color(1, 1, 1, 1);
            }
            else
            {
                EndGame();
            }
        }
         else
        {
            if (Taiwan == false)
            {
                Taiwan = true;
                Icons[2].color = new Color(1, 1, 1, 1);
            }
            else
            {
                EndGame();
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
       Egganimator.SetBool("Egging", false);
    }
    public void EndGame()
    {
        EndBoard.SetActive(true);
        EndPic.sprite = mygame.myUniverse.UniversePic;
        if (Viewer<=1000)
        {
            EndString.text = "�A�樭�T�Q�~���]�k�èS���ƻ�ΡC\r\n �o�ױN���o���q�q�L�D�����~�A\r\n�M���Y�Ӥ����W�k�l�]�F�a�C";
        }
        else if (Viewer <= 75000)
        {
            EndString.text = "�ǥѧA���]�k�A�o�b�o�̫᪺�ɥ��۸����e���F���D�ʪ����ɡC\r\n�γ\���M�u�O�ӤpV�A���s�b��F�Y�ǤH�ߤ��C\r\n���Y�ѡA�A�z�L�]�k�o�ݨ�A�o�������H��Y�Ӥ����W�k�l�]�F......\r\n�o�̨M�w�^�m�U�i�����ݵۦ��@�ѯ���b�L�������ɤW���";
        }
        else if (Viewer <= 100000)
        {
            EndString.text = "�z�L�A�����U�A�o�b���~�e����F�ȬޡC\r\n�o�]��O�@�ӯ�W��@����V�F�A�\�h�H���o�����~�P��{���C\r\n���Y�ѡA�A�z�L�]�k�o�ݨ�A�o�������H��Y�Ӥ����W�k�l�]�F......\r\n";
        }
        else
        {
            EndString.text = "�o�����F�F�������W��Vtuber�A���~���ѳгy�F�̫᪺���^�C\r\n �A�q�S�Q�L�A�L�h���˪��o�]���o�@�ѡC\r\n �M�ӬY�ѡA�Ať��@�Ǫ��@�ﱡ�Q�b�ή��R�A�A���Ӥ��H���N�C\r\n���A�k�誺�n���o���A�L����x......";
        }
        EndViewer.text = Viewer.ToString();
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
