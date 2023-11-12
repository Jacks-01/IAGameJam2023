using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pterodactyl : MonoBehaviour
{
    Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
	rigidBody.velocity = new Vector3(0, 0, -70);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidBody.velocity -= new Vector3(0, Mathf.Sin(Time.time / 100) * .1f, 0);
    }
}
