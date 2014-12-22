using UnityEngine;
using System.Collections;

public class SkinTone : ClickableObject
{
    public Material _personaMat;
    public Color _color;

    public override void OnClick()
    {
        if (_personaMat.color != _color)
        {
            _personaMat.color = _color;
            Manager.Instance.IsWhite = false;
        }
        else
        {
            _personaMat.color = Manager.Instance._whiteSkinTone;
            Manager.Instance.IsWhite = true;
        }


        base.OnClick();
    }

}
