using UnityEngine;
using UnityEngine.UI;

public class SwitchButtonsPanelScript : MonoBehaviour
{
    [SerializeField] Button[] buttons;

    public void SetAllButtonsInteractable()
    {
        foreach (Button button in buttons)
        {
            button.interactable = true;
        }
    }

    public void OnButtonClicked(Button clickedButton)
    {
        int buttonIndex = System.Array.IndexOf(buttons, clickedButton);

        if (buttonIndex == -1)
            return;

        clickedButton.interactable = false;
    }

    public void ResetB()
    {
        
            SetAllButtonsInteractable();
        
    }

}