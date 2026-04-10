using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PostFeed : MonoBehaviour
{
    [SerializeField] Ui_Element[] feedPosts;
    [SerializeField] GameObject[] postPanel;
    int post;

    void LoadPost(int postNum)
    {
        UiContainers uiContainer = postPanel[postNum].GetComponent<UiContainers>();
        uiContainer.textUsernameField.text = feedPosts[postNum].username;
        uiContainer.textCaptionField.text = feedPosts[postNum].caption;
        uiContainer.imageImageField.sprite = feedPosts[postNum].picture;
        uiContainer.textLikesField.text = feedPosts[postNum].likes;
    }

    void Start()
    {
        LoadPost(0);
    }
}