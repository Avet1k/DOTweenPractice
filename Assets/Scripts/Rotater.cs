using System;
using DG.Tweening;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    [SerializeField] private Vector3 _endValue;
    [SerializeField] private float _duration;
    [SerializeField] private RotateMode _mode;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;
    
    private void Start()
    {
        transform.DORotate(_endValue, _duration, _mode).SetLoops(_repeats, _loopType);
    }
}
