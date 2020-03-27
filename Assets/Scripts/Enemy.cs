using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Player player;
    public Rigidbody body;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        Fire();
    }

    // Update is called once per frame
    void Update()
    {
        body.AddForce((player.transform.position - transform.position) * 15f);
    }

    void Fire()
    {
        GameObject obj = Instantiate(bullet, this.transform.position, Quaternion.Euler(0f, 0f, 90f));
        obj.GetComponent<Bullet>().forward = player.transform.position - transform.position;
    }
}
