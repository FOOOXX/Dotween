using DG.Tweening;
using UnityEngine;

public class ToTurn : MonoBehaviour
{
    private Quaternion _currentRotate;

    private void Start()
    {
        _currentRotate = transform.rotation;

        Tween tween = transform.DORotate(new Vector3(_currentRotate.x + 360, _currentRotate.y + 360, 0), 5, RotateMode.FastBeyond360);

        tween.SetLoops(-1).SetEase(Ease.Linear);
    }
}
