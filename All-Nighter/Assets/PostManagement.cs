using UnityEngine;
using System.Collections.Generic;

public class PostManagement : MonoBehaviour
{

    public List<GameObject> posts = new List<GameObject> ();
    [SerializeField] Transform slot1;
    [SerializeField] Transform slot2; //viewable
    [SerializeField] Transform slot3;

    int currentPost = 0;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void NextPost()
    {
        posts[currentPost].transform.position = slot1.position;
        currentPost++;
        posts[currentPost].transform.position = slot2.position;
        int npost = currentPost + 1; 
        posts[npost].transform.position = slot3.position;
    }
    void PrevPost()
    {
        posts[currentPost].transform.position = slot3.position;
        currentPost--;
        posts[currentPost].transform.position = slot2.position;
        int npost = currentPost - 1;
        posts[npost].transform.position = slot1.position;
    }

}
