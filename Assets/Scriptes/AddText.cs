using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class AddText : MonoBehaviour
{
    private Text _text;

    private void Start()
    {
        _text = GetComponent<Text>();

        _text.DOText("Это дополнение.", 3).SetRelative();
    }
}
