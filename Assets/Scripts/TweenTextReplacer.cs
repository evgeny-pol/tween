using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TweenTextReplacer : TweenProvider
{
    [SerializeField] private string _text;
    [SerializeField, Min(0f)] private float _duration = 1f;
    [SerializeField] private ScrambleMode _scrambleMode = ScrambleMode.None;

    private Text _textField;

    private void Awake()
    {
        _textField = GetComponent<Text>();
    }

    public override Tween GetTween() =>
        _textField.DOText(_text, _duration, scrambleMode: _scrambleMode);
}
