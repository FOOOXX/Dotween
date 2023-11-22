using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class ReplacingText : MonoBehaviour
{
    private Text _text;
    private float _duration;

    private void Start()
    {
        _text = GetComponent<Text>();
        _duration = 3;

        _text.DOText("Этот текст заменен", _duration);
    }
}
