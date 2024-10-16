using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class TweenColorChanger : TweenProvider
{
    [SerializeField] private Color _color;
    [SerializeField, Min(0f)] private float _duration = 1f;

    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    public override Tween GetTween() =>
        _renderer.material.DOColor(_color, _duration);
}
