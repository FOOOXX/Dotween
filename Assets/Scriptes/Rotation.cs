using DG.Tweening;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private Quaternion _targetRotate;
    private float _duration;

    private void Start()
    {
        _duration = 5;
        _targetRotate = new(transform.localRotation.x + 360, transform.localRotation.y + 360, transform.localRotation.z, 0);

        Tween tween = transform.DORotate(_targetRotate.eulerAngles, _duration, RotateMode.FastBeyond360);

        tween.SetLoops(-1).SetEase(Ease.Linear);
    }
}
