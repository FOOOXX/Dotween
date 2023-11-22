using UnityEngine;
using DG.Tweening;

public class Movement : MonoBehaviour
{
    private Vector3 _target;
    private float _duration;

    private void Start()
    {
        _target = new(transform.position.x, transform.position.y, transform.position.z + 9);

        _duration = 5;

        Tween tween = transform.DOMove(_target, _duration);

        tween.SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}