using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody body;
    public Transform direction;
    private float scalar = 50f;
    private bool grounded;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            body.AddForce(direction.forward * scalar);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            body.AddForce(-direction.right * scalar);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            body.AddForce(direction.right * scalar);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            body.AddForce(-direction.forward * scalar);
        }

        if (Input.GetKeyDown(KeyCode.Space) && grounded == true)
        {
            body.AddForce(direction.up * scalar * 10f);
        }

        if (Input.GetMouseButtonDown(0))
        {
            GameObject obj = Instantiate(bullet, this.transform.position, Quaternion.Euler(0f, 0f, 90f));
            obj.GetComponent<Bullet>().forward = direction.forward;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Ground")
        {
            grounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "Ground")
        {
            grounded = false;
        }
    }
}
