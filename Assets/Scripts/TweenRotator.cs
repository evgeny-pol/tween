using DG.Tweening;
using UnityEngine;

public class TweenRotator : TweenProvider
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField, Min(0f)] private float _duration = 1f;
    [SerializeField] private RotateMode _rotateMode = RotateMode.Fast;

    public override Tween GetTween() =>
        transform.DORotate(_rotation, _duration, _rotateMode);
}
