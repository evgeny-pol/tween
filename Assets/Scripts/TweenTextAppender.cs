using DG.Tweening;

public class TweenTextAppender : TweenTextReplacer
{
    public override Tween GetTween() =>
        base.GetTween().SetRelative();
}
