using DG.Tweening;
using UnityEngine;

public class TweenScaler : TweenProvider
{
    [SerializeField] private Vector3 _scale = Vector3.one;
    [SerializeField, Min(0f)] private float _duration = 1f;

    public override Tween GetTween() =>
        transform.DOScale(_scale, _duration);
}
