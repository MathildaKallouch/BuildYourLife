using UnityEngine;
using System.Collections;

public class RobotManager : MonoBehaviour 
{
    public float _cooldown;
    private Timer m_timer;
    private static RobotManager m_instance;

    #region Singleton

    public static RobotManager Instance
    {
        get
        {
            if (m_instance == null)
            {
                m_instance = GameObject.FindObjectOfType<RobotManager>();
                if (m_instance == null)
                {
                    GameObject singleton = new GameObject();
                    singleton.name = "Manager";
                    m_instance = singleton.AddComponent<RobotManager>();
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
        m_timer = new Timer();
    }

    void Update()
    {

    }

    #endregion
}
