using DG.Tweening;
using UnityEngine;

public class Rotater : CommonTweener
{
    [SerializeField] private Vector3 _endValue;
    [SerializeField] private RotateMode _mode;
    
    private void Start()
    {
        transform.DORotate(_endValue, Duration, _mode).SetLoops(Repeats, LoopType);
    }
}
