using UnityEngine;
using DG.Tweening;

public class ToMoveToTurnToScale : MonoBehaviour
{
    private Vector3 _currentPosition;
    private Quaternion _currentRotation;
    private Vector3 _currentScale;

    private void Start()
    {
        _currentPosition = transform.position;
        _currentRotation = transform.rotation;
        _currentScale = transform.localScale;

        Tween move = transform.DOMove(new Vector3(_currentPosition.x, _currentPosition.y, _currentPosition.z + 5), 10);

        ToLoop(move);

        Tween turn = transform.DORotate(new Vector3(_currentRotation.x + 360f, _currentRotation.y + 360f, 0), 10, RotateMode.FastBeyond360);

        ToLoop(turn);

        Tween scale = transform.DOScale(_currentScale * 1.5f, 4);

        ToLoop(scale);
    }

    private void ToLoop(Tween tween)
    {
        tween.SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
