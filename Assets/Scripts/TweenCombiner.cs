using DG.Tweening;
using System.Linq;
using UnityEngine;

public class TweenCombiner : TweenProvider
{
    [SerializeField] private TweenProvider[] _tweenProviders;

    public override Tween GetTween() =>
        _tweenProviders.Aggregate(DOTween.Sequence(), (sequence, tweenProvider) => sequence.Insert(0, tweenProvider.GetTween()));
}
