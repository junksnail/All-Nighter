using UnityEngine;

public class Puzzle4 : Puzzle
{
    public bool liked;
    public bool commented;

    public void CommentDeleted()
    {
        commented = false;
    }

    public void Commented()
    {
        commented = true;
    }
    public void Like()
    {
        liked = true;
    }

    void Unlike()
    {
        liked = false;
    }


    void Update()
    {
        if (CheckIfCurrent())
        {
            if (commented && liked && !completed)
            {
                completed = true;
                AllowNextPage.instance.CompleteEntry(page);
                gameObject.GetComponent<Puzzle4>().enabled = false;

            }
        }
    }
}