using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Puzzle7 : Puzzle
{
    [SerializeField] Sprite sevenFrameOne;
    [SerializeField] Sprite sevenFrameTwo;
    [SerializeField] Sprite eightFrameOne;
    [SerializeField] Sprite eightFrameTwo;
    [SerializeField] Image sevenImage;
    [SerializeField] Image eightImage;

    [SerializeField] TMP_Text textField;

    [SerializeField] GameObject button;

    bool on;
    public bool active; 

    public void LightSwitch()
    {
        Debug.Log("attempting light switch");
        if (active)
        {
            if (!on)
            {
                on = true;

                sevenImage.sprite = sevenFrameTwo;
                eightImage.sprite = eightFrameTwo;
                textField.text = "if you can read this, comment below!";
                if (!completed)
                {
                    Complete();
                    completed = true;
                }
            }
            else if (on)
            {
                on = false;

                sevenImage.sprite = sevenFrameOne;
                eightImage.sprite = eightFrameOne;
                textField.text = "";

            }
        }
    }

    void Complete()
    {
        AllowNextPage.instance.CompleteEntry(page);
    }

    void Check()
    {
        if (AllowNextPage.instance.currentPost == 2 && AllowNextPage.instance.currentPage == 1 && !active)
        {
            active = true;
        }
        if (AllowNextPage.instance.currentPost != 2 || AllowNextPage.instance.currentPage != 1)
        {
            active = false;
        }
    }

    void Update()
    {
        Check();
        if (active) { button.SetActive(true); }
        else { button.SetActive(false); }
    }

}
