using DG.Tweening;
using UnityEngine;

public class TweenMover : TweenProvider
{
    [SerializeField] private Vector3 _offset;
    [SerializeField, Min(0f)] private float _duration = 1f;

    public override Tween GetTween() =>
        transform.DOMove(transform.position + _offset, _duration);
}
