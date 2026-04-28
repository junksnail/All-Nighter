using UnityEngine;

public class Puzzle1 : Puzzle
{
    public bool liked;


    public void Like()
    {
        Debug.Log("Post Liked");
        liked = true;  
    }

    void Unlike()
    {
        Debug.Log("Post Unliked");
        liked = false;
    }

    void Update()
    {
        if (CheckIfCurrent())
        {
            if (liked && !completed)
            {
                Debug.Log("Puzzle Completed");
                completed = true;
                AllowNextPage.instance.CompleteEntry(page);
                gameObject.GetComponent<Puzzle1>().enabled = false;
            }
        }
    }
}
