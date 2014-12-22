using UnityEngine;
using System.Collections;

public class Back : ClickableObject
{
    public override void OnClick()
    {
        LayerManager.Instance.SetLayer("custom");

        base.OnClick();
    }
}
