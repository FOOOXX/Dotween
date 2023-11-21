using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class HackText : MonoBehaviour
{
    private Text _text;

    private void Start()
    {
        _text = GetComponent<Text>();

        _text.DOText("Этот текст взломан.", 3, true, ScrambleMode.All);
    }
}
