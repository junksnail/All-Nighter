using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiContainers : MonoBehaviour
{
    public TMP_Text textUsernameField;
    public TMP_Text textCaptionField;
    public TMP_Text textLikesField;
    public Image imageImageField;

    Vector3 reset;

    void Start()
    {
        reset = gameObject.transform.position;
    }

    public void Reset()
    {
        gameObject.transform.position = reset;
    }
}
