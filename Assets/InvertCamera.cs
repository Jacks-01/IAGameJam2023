using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Camera>().projectionMatrix = GetComponent<Camera>().projectionMatrix * Matrix4x4.Scale(new Vector3(-1, 1, 1));

    }


}
