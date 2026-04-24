using UnityEngine;

public class Puzzle2 : Puzzle
{
    public bool commented;

    void CommentedDeleted()
    {
        commented = false;
    }

    public void Commented()
    {
        commented = true;
    }

    void Update()
    {
        if (CheckIfCurrent())
        {
            if (commented && !completed)
            {
                completed = true;
                AllowNextPage.instance.CompleteEntry(page);
                gameObject.GetComponent<Puzzle2>().enabled = false;
            }
        }
    }
}
