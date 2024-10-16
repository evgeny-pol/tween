using DG.Tweening;
using UnityEngine;

public class TweenEaser : TweenWrapper
{
    [SerializeField] private Ease _ease = Ease.Linear;

    public override Tween GetTween(Tween tween) =>
        tween.SetEase(_ease);
}
