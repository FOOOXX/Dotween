using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(MeshRenderer))]

public class ColorChange : MonoBehaviour
{
    private MeshRenderer _meshRenderer;
    private float _duration;

    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _duration = 4;

        Tween tween = _meshRenderer.material.DOColor(Color.red, _duration);
        
        tween.SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
