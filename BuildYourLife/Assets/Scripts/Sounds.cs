using UnityEngine;
using System.Collections;

public class Sounds : ClickableObject
{
    private Timer _timer;
    public float _cooldown;

    void Awake()
    {
        _timer = new Timer();
    }

    public override void OnClick()
    {
        if(_timer.IsElapsedLoop && _cooldown > 0f)
        {
            base.OnClick();
            _timer.Reset(_cooldown);
        }
    }

}
