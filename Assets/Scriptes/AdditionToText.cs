using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class AdditionToText : MonoBehaviour
{
    private Text _text;
    private float _duration;

    private void Start()
    {
        _text = GetComponent<Text>();
        _duration = 3;

        _text.DOText("Это дополнение.", _duration).SetRelative();
    }
}
