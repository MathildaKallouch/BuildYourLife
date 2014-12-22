using UnityEngine;
using System.Collections;

public class Activable : ClickableObject
{
    public GameObject[] _items;


    public override void OnClick()
    {
        foreach(GameObject item in _items)
        {
            if (item != null)
            {
                item.SetActive(!item.activeSelf);
                if (item.name == "sexeM")
                {
                    Manager.Instance.HasDick = item.activeSelf;
                }

                if (item.name == "seins")
                {
                    Manager.Instance.HasBoobs = item.activeSelf;
                }

                if (item.name == "billets")
                {
                    Manager.Instance.HasMoney = item.activeSelf;
                }
            }
        }

        base.OnClick();
    }
}
