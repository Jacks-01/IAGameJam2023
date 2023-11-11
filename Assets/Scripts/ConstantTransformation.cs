using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantTransformation : MonoBehaviour
{
    public Vector3 moveVelocity;
    public Vector3 rotationSpeed;

    void Update()
    {
        transform.Translate(moveVelocity * Time.deltaTime);

        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
