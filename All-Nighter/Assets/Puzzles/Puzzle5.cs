using UnityEngine;

public class Puzzle5 : MonoBehaviour
{
    bool completed;
    bool liked;
    bool commented;
    bool subscribed;

    void CommentDeleted()
    {
        commented = false;
    }

    void Commented()
    {
        commented = true;
    }
    void Like()
    {
        liked = true;
    }

    void Unlike()
    {
        liked = false;
    }


    void Update()
    {
        if (commented && liked && !completed)
        {
            completed = true;
            AllowNextPage.instance.CompleteEntry();

        }
    }
}