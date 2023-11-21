using UnityEngine;
using DG.Tweening;

public class ChangeColor : MonoBehaviour
{
    private MeshRenderer _meshRenderer;

    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();

        Tween tween = _meshRenderer.material.DOColor(Color.red, 4);
        
        tween.SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
