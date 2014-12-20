using UnityEngine;
using System.Collections;

public abstract class ClickableObject : MonoBehaviour 
{
	
	public virtual void OnClick()
    {
        Manager.Instance.IsBlank();
    }
}
