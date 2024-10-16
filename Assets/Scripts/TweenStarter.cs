using UnityEngine;

public class TweenStarter : MonoBehaviour
{
    [SerializeField] private TweenProvider _tweenProvider;

    private void Start()
    {
        _tweenProvider.GetTween();
    }
}
