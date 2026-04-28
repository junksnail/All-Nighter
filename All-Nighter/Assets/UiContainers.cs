using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiContainers : MonoBehaviour
{
    SwitchButtonsPanelScript sbps;

    public TMP_Text textUsernameField;
    public TMP_Text textCaptionField;
    public TMP_Text textLikesField;
    public TMP_Text textFollowersField;
    
    public Image imageImageField;

    Vector3 reset;

    void Start()
    {
        sbps = gameObject.GetComponent<SwitchButtonsPanelScript>();
        reset = gameObject.transform.position;
    }

    public void Reset()
    {
        gameObject.transform.position = reset;
        sbps.ResetB();
    }
}
