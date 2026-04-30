using UnityEngine;

public class Puzzle6 : Puzzle
{
    public bool active;
    [SerializeField] GameObject image;
    public Vector3 location;
    public Vector3 publicLocation;
    Vector3 targetPosition;
    bool isSet;
    public bool xp;
    public bool yp;

    void Start()
    {
        targetPosition = image.transform.position;
    }

    void Update()
    {
        Check();
        Move();
        PuzzleComplete();
        publicLocation = image.transform.position;
    }

    void Check()
    {
        if (AllowNextPage.instance.currentPost == 0 && AllowNextPage.instance.currentPage == 1 && !active)
        {
            image.transform.position = location;
            active = true;
        }
        if (AllowNextPage.instance.currentPost != 0 || AllowNextPage.instance.currentPage != 1)
        {
            active = false; 
        }

        
    }

    void PuzzleComplete()
    {
        if (image.transform.position.x < targetPosition.x + 0.2 && image.transform.position.x > targetPosition.x - 0.2 && active)
        {
            xp = true;
        }
        if (image.transform.position.y < targetPosition.y + 0.2 && image.transform.position.y > targetPosition.y - 0.2 && active)
        {
            yp = true;
        }
        if (yp && xp)
        {

            image.transform.position = targetPosition;
            if (!completed)
            {
                completed = true;
                AllowNextPage.instance.CompleteEntry(page);
                gameObject.GetComponent<Puzzle2>().enabled = false;
            }
        }
    }

    void Move()
    {
        if (active && !completed)
        {
            if (Input.GetKey(KeyCode.W))
            {
                image.transform.position = image.transform.position + new Vector3(0, 1 * Time.deltaTime, 0);   
            }
            if (Input.GetKey(KeyCode.S))
            {
                image.transform.position = image.transform.position - new Vector3(0, 1 * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.A))
            {
                image.transform.position = image.transform.position - new Vector3(1 * Time.deltaTime,0 , 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                image.transform.position = image.transform.position + new Vector3(1 * Time.deltaTime, 0, 0);
            }
        }
    }

}
