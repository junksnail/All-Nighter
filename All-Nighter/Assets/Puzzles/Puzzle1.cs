using UnityEngine;

public class Puzzle1 : MonoBehaviour
{
    bool completed;
    public bool liked;

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
        if (liked && !completed)
        {
            completed = true;
            AllowNextPage.instance.CompleteEntry();
        }
    }
}
