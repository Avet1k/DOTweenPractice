using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextScrambler : CommonTweener
{
    [SerializeField] private Text _text;
    [SerializeField] private string _newText;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(_newText, Duration));
        sequence.Append(_text.DOText(_newText, Duration).SetRelative(true));
        sequence.Append(_text.DOText(_newText, Duration, true, ScrambleMode.All));
        sequence.SetLoops(Repeats, LoopType);
    }
}
