using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [HideInInspector]
    public Vector3 forward;
    Vector3 startForward;

    // Start is called before the first frame update
    void Start()
    {
        startForward = forward;
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + startForward * Time.deltaTime * 10f;
    }
}
