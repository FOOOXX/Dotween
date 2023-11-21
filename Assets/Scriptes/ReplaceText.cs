using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ReplaceText : MonoBehaviour
{
    private Text _text;

    private void Start()
    {
        _text = GetComponent<Text>();

        _text.DOText("Этот текст заменен", 3);
    }
}
