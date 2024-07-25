using DG.Tweening;
using UnityEngine;

public class Scaler : CommonTweener
{
    [SerializeField] private float _size;

    private void Start()
    {
        transform.DOScale(_size, Duration).SetLoops(Repeats, LoopType);
    }
}
