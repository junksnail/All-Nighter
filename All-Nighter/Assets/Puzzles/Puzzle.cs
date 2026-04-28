using UnityEngine;

public class Puzzle : MonoBehaviour
{
    public bool completed;
    public int page;

   public bool CheckIfCurrent()
    {
        if (AllowNextPage.instance.currentPage == page)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void Update()
    {

    }
}
