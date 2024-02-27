using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] float moveSpeed = 0.01f;
    [SerializeField] float upSpeed = 0.02f;
    [SerializeField] float downSpeed = 0.009f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float stearAmor = Input.GetAxis("Horizontal")*steerSpeed*Time.deltaTime;
        float moveAmor = Input.GetAxis("Vertical") * moveSpeed*Time.deltaTime;
        transform.Rotate(0, 0, -stearAmor);
        transform.Translate(0, moveAmor, 0);

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = downSpeed;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "SpeedUp")
        {
            moveSpeed = upSpeed;
        }
    }
}
