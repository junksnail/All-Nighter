using UnityEngine;

public class Puzzle3 : Puzzle
{
    public bool subscribed;

    void unSubscribed()
    {
        subscribed = false;
    }

    public void Subscribed()
    {
        subscribed = true;
    }

    void Update()
    {
        if (CheckIfCurrent())
        {
            if (subscribed && !completed)
            {
                completed = true;
                AllowNextPage.instance.CompleteEntry(page);
                gameObject.GetComponent<Puzzle3>().enabled = false;
            }
        }
    }
}

