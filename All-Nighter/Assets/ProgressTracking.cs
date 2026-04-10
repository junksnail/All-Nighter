using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProgressTracking : MonoBehaviour
{
    enum Progress { StageOne, StageTwo, StageThree, StageFour }

    void Start()
    {
        Progress myProgress;
        myProgress = Progress.StageOne;
        Debug.Log(myProgress);
    }



}