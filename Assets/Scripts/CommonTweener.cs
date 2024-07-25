using DG.Tweening;
using UnityEngine;

public abstract class CommonTweener : MonoBehaviour
{
    [SerializeField] protected float Duration;
    [SerializeField] protected int Repeats;
    [SerializeField] protected LoopType LoopType;
}
