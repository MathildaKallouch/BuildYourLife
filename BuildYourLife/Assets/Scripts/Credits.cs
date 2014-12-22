using UnityEngine;
using System.Collections;

public class Credits : ClickableObject 
{
    public override void OnClick()
    {
        LayerManager.Instance.SetLayer("credits");

        base.OnClick();
    }
}
