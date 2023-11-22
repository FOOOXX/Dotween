using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class TextHacking : MonoBehaviour
{
    private Text _text;
    private float _duration;

    private void Start()
    {
        _text = GetComponent<Text>();
        _duration = 3;

        _text.DOText("Этот текст взломан.", _duration, true, ScrambleMode.All);
    }
}
