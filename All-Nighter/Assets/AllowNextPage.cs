using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

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

    public GameObject UpButton;
    public GameObject DownButton;

    public TMP_Text num;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        MoveToNextPost();
        MoveToPreviousPost();
        CheckForNext();
        UI();
    }

    void Start()
    {
        int fixPage = currentPage + 1;
        num.text = fixPage.ToString();
    }

    void UI()
    {
        if (currentPost == 0)
        {
            UpButton.SetActive(false);
        }
        if (currentPost != 0)
        {
            UpButton.SetActive(true);
        }
        if (currentPost == 4)
        {
            DownButton.SetActive(false);
        }
        if (currentPost != 4)
        {
            DownButton.SetActive(true);
        }
    }

    public void CompleteEntry(int page)
    {
        PageProgress[page]++;
    }

    public void ButtonMoveNext()
    {
        if (currentPost < 4)
        {
            currentPost++;
            content.transform.position = content.transform.position + new Vector3(0, 7.33141902f, 0);
        }
    }

    public void ButtonMoveLast()
    {
        if (currentPost > 0)
        {
            currentPost--;
            content.transform.position = content.transform.position - new Vector3(0, 7.33141902f, 0);
        }
    }

    public void MoveToNextPost()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) && !pressed && currentPost < 4)
        {
            pressed = true;
            currentPost++;
            
            content.transform.position = content.transform.position + new Vector3(0, 7.33141902f, 0);

        }
        if (!Input.GetKeyDown(KeyCode.DownArrow))
        {
            pressed = false;
        }
    }

    public void MoveToPreviousPost()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && !pressed && currentPost > 0)
        {
            pressed = true;
            currentPost--;
            content.transform.position = content.transform.position - new Vector3(0, 7.33141902f, 0);
        }
        if (!Input.GetKeyDown(KeyCode.UpArrow))
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
            currentPost = 0;
            PostFeed.instance.NextSet(currentPage);
            int fixPage = currentPage + 1;
            num.text = fixPage.ToString();
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
