using DG.Tweening;
using System.Linq;
using UnityEngine;

public class TweenSequencer : TweenProvider
{
    [SerializeField] private TweenProvider[] _tweenProviders;

    public override Tween GetTween() =>
        _tweenProviders.Aggregate(DOTween.Sequence(), (sequence, tweenProvider) => sequence.Append(tweenProvider.GetTween()));
}
