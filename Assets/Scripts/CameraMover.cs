using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    private Vector3 prev;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        prev = Input.mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
        float diffX = Input.mousePosition.x - prev.x;
        float diffY = Input.mousePosition.y - prev.y;
        float clampedX = transform.eulerAngles.x - diffY;
        Vector3 diffV = new Vector3(clampedX, transform.eulerAngles.y + diffX, transform.eulerAngles.z);
        transform.eulerAngles = Vector3.MoveTowards(transform.eulerAngles, diffV, 5f);
        prev = Input.mousePosition;
        
    }
}
