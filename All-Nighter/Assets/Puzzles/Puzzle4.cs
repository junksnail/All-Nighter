using UnityEngine;

public class Puzzle4 : MonoBehaviour
{
    bool completed;
    bool subscribed;

    void unSubscribed()
    {
        subscribed = false;
    }

    void Subscribed()
    {
        subscribed = true;
    }

    void Update()
    {
        if (subscribed && !completed)
        {
            completed = true;
            AllowNextPage.instance.CompleteEntry();
        }
    }
}
