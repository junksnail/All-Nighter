using UnityEngine;

public class Puzzle5 : Puzzle
{
    public bool liked;
    public bool commented;
    public bool subscribed;

    void unSubscribed()
    {
        subscribed = false;
    }

    public void Subscribed()
    {
        subscribed = true;
    }

    void CommentedDeleted()
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
            if (commented && liked && subscribed && !completed)
            {
                completed = true;
                AllowNextPage.instance.CompleteEntry(page);
                gameObject.GetComponent<Puzzle5>().enabled = false;
            }
        }
    }
}
