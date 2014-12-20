using UnityEngine;
using System.Collections;

public class SexualPreferences : ClickableObject 
{
    public TextMesh _personaText;
    public TextMesh _itemText;

    public override void OnClick()
    {
        if (_personaText.text != _itemText.text)
        {
            _personaText.text = _itemText.text;
            Manager.Instance.IsStraight = false;
        }
        else
        {
            _personaText.text = "I'm straight";
            Manager.Instance.IsStraight = true;
        }

        base.OnClick();
    }
}
