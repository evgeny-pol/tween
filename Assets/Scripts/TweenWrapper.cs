using DG.Tweening;
using UnityEngine;

public abstract class TweenWrapper : TweenProvider
{
    [SerializeField] private TweenProvider _tweenProvider;

    public override sealed Tween GetTween() =>
        GetTween(_tweenProvider.GetTween());

    public abstract Tween GetTween(Tween tween);
}
