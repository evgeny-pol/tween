using DG.Tweening;
using UnityEngine;

public class TweenLooper : TweenWrapper
{
    [SerializeField, Min(-1)] private int _loops = -1;
    [SerializeField] private LoopType _loopType = LoopType.Yoyo;

    public override Tween GetTween(Tween tween) =>
        tween.SetLoops(_loops, _loopType);
}
