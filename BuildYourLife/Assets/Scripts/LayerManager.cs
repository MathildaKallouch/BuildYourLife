using UnityEngine;
using System.Collections;

public class LayerManager : MonoBehaviour 
{
    public GameObject _customLayer;
    public GameObject _creditsLayer;
    public GameObject _aboutLayer;

    private static LayerManager m_instance;

    #region Singleton

    public static LayerManager Instance
    {
        get
        {
            if (m_instance == null)
            {
                m_instance = GameObject.FindObjectOfType<LayerManager>();
                if (m_instance == null)
                {
                    GameObject singleton = new GameObject();
                    singleton.name = "Manager";
                    m_instance = singleton.AddComponent<LayerManager>();
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
        SetLayer("custom");
    }

    #endregion

    public void SetLayer(string layerName)
    {
        _customLayer.SetActive(layerName == "custom" ? true : false);
        _creditsLayer.SetActive(layerName == "credits" ? true : false);
        _aboutLayer.SetActive(layerName == "about" ? true : false);
    }
}
