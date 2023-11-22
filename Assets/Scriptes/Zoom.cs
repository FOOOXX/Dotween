using UnityEngine;
using DG.Tweening;

public class Zoom : MonoBehaviour
{
    private Vector3 _target;
    private float _duration;

    private void Start()
    {
        _target = transform.localScale * 1.3f;
        _duration = 5;

        Tween tween = transform.DOScale(_target, _duration);

        tween.SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
