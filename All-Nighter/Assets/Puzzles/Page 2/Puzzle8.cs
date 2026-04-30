using UnityEngine;

public class Puzzle8 : Puzzle
{
    public bool commented;


    public void Commented()
    {
        commented = true;
        Debug.Log("Commented on post 7");
    }

    void Update()
    {
        if (CheckIfCurrent())
        {
            if (commented && !completed)
            {
                Debug.Log("puzzle 8 complete");
                completed = true;
                AllowNextPage.instance.CompleteEntry(page);
                gameObject.GetComponent<Puzzle8>().enabled = false;
            }
        }
    }
}
