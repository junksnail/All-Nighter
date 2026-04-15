using UnityEngine;

public class Puzzle2 : MonoBehaviour
{
    bool completed;
    bool commented;

    void CommentedDeleted()
    {
        commented = false;
    }

    void Commented()
    {
        commented = true;
    }

    void Update()
    {
        if (commented && !completed)
        {
            completed = true;
            AllowNextPage.instance.CompleteEntry();
        }
    }
}
