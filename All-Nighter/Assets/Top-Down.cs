using UnityEngine;

public class TopDown : MonoBehaviour
{
    public float turnSpeedLeft;
    public float turnSpeedRight;
    public float moveSpeed = 1f;
    public Rigidbody2D rb;
    Vector2 movement;

    void Update()
    {
        // Get input from keyboard

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.up * moveSpeed * Time.deltaTime;
        }



    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            float rotAmount = turnSpeedLeft * Time.deltaTime;
            float curRot = transform.localRotation.eulerAngles.z;
            transform.localRotation = Quaternion.Euler(new Vector3(0, 0, curRot + rotAmount));
        }
        if (Input.GetKey(KeyCode.D))
        {
            float rotAmount = turnSpeedRight * Time.deltaTime;
            float curRot = transform.localRotation.eulerAngles.z;
            transform.localRotation = Quaternion.Euler(new Vector3(0, 0, curRot + rotAmount));
        }
    }
}
