using UnityEngine;
using System.Collections;

public class About : ClickableObject
{
    public override void OnClick()
    {
        LayerManager.Instance.SetLayer("about");

        base.OnClick();
    }
}
