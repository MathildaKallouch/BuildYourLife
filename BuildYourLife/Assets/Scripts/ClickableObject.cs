using UnityEngine;
using System.Collections;

public abstract class ClickableObject : MonoBehaviour 
{
    private AudioSource m_source;

    public AudioClip _audioClip;

    void Start()
    {
        m_source = GameObject.Find("SoundEffects").GetComponent<AudioSource>();
    }

	public virtual void OnClick()
    {

        if (m_source != null && _audioClip != null)
        {
            m_source.Stop();
            m_source.clip = _audioClip;
            m_source.Play();
        }

        Manager.Instance.IsBlank();
    }
}
