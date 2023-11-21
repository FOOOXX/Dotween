using UnityEngine;
using DG.Tweening;

public class ToMove : MonoBehaviour
{
    private Vector3 _currentPosition;

    private void Start()
    {
        _currentPosition = transform.position;

        Tween tween = transform.DOMove(new Vector3(_currentPosition.x, _currentPosition.y, _currentPosition.z + 9), 5);

        tween.SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}