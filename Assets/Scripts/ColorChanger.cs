using DG.Tweening;
using UnityEngine;

public class ColorChanger : CommonTweener
{
    [SerializeField] private Renderer _renderer;
    [SerializeField] private Color _color;

    private void Start()
    {
        _renderer.material.DOColor(_color, Duration).SetLoops(Repeats, LoopType);
    }
}
