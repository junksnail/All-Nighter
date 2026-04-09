using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Ui_Element", menuName = "ScriptableObjects/Ui_Element", order = 2)]
public class Ui_Element : ScriptableObject
{
    public string username;
    public Sprite picture;

    [TextArea] public string caption;

    public int likes;
    public int shares;
}

