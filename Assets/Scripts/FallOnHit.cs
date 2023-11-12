using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallOnHit : MonoBehaviour
{
    public bool fallOnHit = true;
    private Rigidbody myRigidBody;

    private Collider myCollider;



    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
        myCollider = GetComponent<Collider>();
    }
    public void OnPlayerHit()
    {


        if (fallOnHit && myRigidBody != null)
        {
            myRigidBody.isKinematic = false;
            myCollider.isTrigger = false;
            transform.parent = null;
        }
        Debug.Log("Player has been hit");
    }
}
