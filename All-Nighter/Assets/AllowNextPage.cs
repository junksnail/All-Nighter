using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AllowNextPage : MonoBehaviour
{
    int currentPage; 
    List<int> PageProgress = new List<int>(); // tracks how many (out of 5) puzzles are completed (skips [0])

    public static AllowNextPage instance;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void CompleteEntry()
    {
        PageProgress[currentPage] += 1; 
    }

    public void MoveToNextPage()
    {
        if (PageProgress[currentPage] == 5)
        {
            currentPage += 1;
        }
    }

    public void MoveToPreviousPage()
    {
        currentPage -= 1;
    }
}
