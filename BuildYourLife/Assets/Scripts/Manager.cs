using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour 
{
    private static Manager m_instance;

    public TextMesh _text;
    public GameObject _money;
    public GameObject _boobs;
    public GameObject _dick;
    public GameObject _cunt;
    public Material _personaMat;
    public Color _whiteSkinTone;

    public bool HasDick { get; set; }

    public bool HasBoobs { get; set; }

    public bool IsWhite { get; set; }

    public bool HasMoney { get; set; }

    public bool IsStraight { get; set; }

    #region Singleton

    public static Manager Instance
    {
        get
        {
            if (m_instance == null)
            {
                m_instance = GameObject.FindObjectOfType<Manager>();
                if (m_instance == null)
                {
                    GameObject singleton = new GameObject();
                    singleton.name = "Manager";
                    m_instance = singleton.AddComponent<Manager>();
                }
            }

            return m_instance;
        }
    }

    void Awake()
    {
        if (m_instance == null)
        {
            m_instance = this;
            m_instance.Init();
        }
        else
        {
            if (this != m_instance)
                Destroy(this.gameObject);
        }
    }

    private void Init()
    {
        Reset();
    }

    public void Reset()
    {

        HasDick = true;
        HasBoobs = false;
        IsWhite = true;
        HasMoney = true;
        IsStraight = true;

        _text.text = "I'm straight";
        _money.SetActive(true);
        _dick.SetActive(true);
        _cunt.SetActive(false);
        _boobs.SetActive(false);
        _personaMat.color = _whiteSkinTone;
    }

    #endregion

    public void IsBlank()
    {
        TextMesh tm = GameObject.Find("Titles/Title").GetComponent<TextMesh>();

        if (HasDick && !HasBoobs && IsWhite && HasMoney && IsStraight)
        {
            if (tm)
            {
                tm.text = "Your blank";
            }
        }
        else
        {
            if (tm)
            {
                tm.text = "Your";
            }
        }
    }

}
