using UnityEngine;
using DG.Tweening;

public class ToScaleUp : MonoBehaviour
{
    private Vector3 _currentScale;

    private void Start()
    {
        _currentScale = transform.localScale;

        Tween tween = transform.DOScale(_currentScale * 1.3f, 5);

        tween.SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
