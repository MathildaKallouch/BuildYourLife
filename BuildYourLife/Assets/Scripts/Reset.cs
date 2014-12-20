using UnityEngine;
using System.Collections;

public class Reset : ClickableObject
{
    public override void OnClick()
    {
        Manager.Instance.Reset();

        base.OnClick();
    }
}
