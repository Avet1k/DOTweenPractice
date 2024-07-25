using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextScrambler : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private string _newText;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(_newText, _duration));
        sequence.Append(_text.DOText(_newText, _duration).SetRelative(true));
        sequence.Append(_text.DOText(_newText, _duration, true, ScrambleMode.All));
        sequence.SetLoops(_repeats, _loopType);
    }
}
