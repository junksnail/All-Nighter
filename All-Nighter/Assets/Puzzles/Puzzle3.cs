using UnityEngine;

public class Puzzle3 : MonoBehaviour
{
    bool completed;
    bool liked;
    bool commented;
    bool subscribed;

    void unSubscribed()
    {
        subscribed = false;
    }

    void Subscribed()
    {
        subscribed = true;
    }

    void CommentedDeleted()
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
        if (commented && liked && subscribed && !completed)
        {
            completed = true;
            AllowNextPage.instance.CompleteEntry();
            
        }
    }
}
