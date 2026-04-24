using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AllowNextPage : MonoBehaviour
{
    bool pressed;
    public int currentPost; 
    public int currentPage;
    public List<int> PageProgress = new List<int>(); // tracks how many (out of 5) puzzles are completed (skips [0])
    public List<bool> PagesCompleted = new List<bool> ();

    [SerializeField] GameObject content;
    public List<GameObject> posts;
    public Transform[] slots;

    public static AllowNextPage instance;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        MoveToNextPost();
        MoveToPreviousPost();
        CheckForNext();
    }

    public void CompleteEntry(int page)
    {
        PageProgress[page]++;
    }

    public void MoveToNextPost()
    {
        if (Input.GetKeyDown("DownArrow") && !pressed && currentPost < 4)
        {
            pressed = true;
            currentPost++;
            
            content.transform.position = content.transform.position + new Vector3(0, 7.33141902f, 0);

        }
        if (!Input.GetKeyDown("DownArrow"))
        {
            pressed = false;
        }
    }

    public void MoveToPreviousPost()
    {
        if (Input.GetKeyDown("UpArrow") && !pressed && currentPost > 0)
        {
            pressed = true;
            currentPost--;
            content.transform.position = content.transform.position - new Vector3(0, 7.33141902f, 0);
        }
        if (!Input.GetKeyDown("UpArrow"))
        {
            pressed = false;
        }
    }

    void CheckForNext()
    {
        if (PageProgress[currentPage] == 5)
        {
            PagesCompleted[currentPage] = true;
        }
    }

    public void MoveToNextPage()
    {
        if (PagesCompleted[currentPage] == true)
        {
            currentPage++;
        }
    }

    public void MoveToLastPage()
    {
        if (currentPage > 0)
        {
            currentPage--;
        }
    }
}
