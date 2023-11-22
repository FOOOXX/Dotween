using UnityEngine;
using DG.Tweening;

public class MovementWithRotationAndZoom : MonoBehaviour
{
    private Vector3 _targetPosition;
    private Vector3 _targetScale;
    private Quaternion _targetRotation;

    private float _duration;

    private void Start()
    {
        _targetPosition = new(transform.position.x, transform.position.y, transform.position.z + 5);

        _targetRotation = new(transform.localRotation.x + 360, transform.localRotation.y + 360, transform.localRotation.z + 360, 0);
        
        _targetScale = transform.localScale * 1.5f;
        
        _duration = 5;

        Tween move = transform.DOMove(_targetPosition, _duration);

        ToLoop(move);

        Tween rotation = transform.DORotate(_targetRotation.eulerAngles, _duration, RotateMode.FastBeyond360);

        ToLoop(rotation);

        Tween scale = transform.DOScale(_targetScale, _duration);

        ToLoop(scale);
    }

    private void ToLoop(Tween tween)
    {
        tween.SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
