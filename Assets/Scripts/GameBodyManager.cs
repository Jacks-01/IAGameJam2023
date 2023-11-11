using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameBodyManager : MonoBehaviour
{
    public BodySourceView bodySourceView;

    private void OnEnable()
    {
        bodySourceView.OnBodyCreated += CreateBody;
    }

    private void CreateBody(BodyParts bodyParts)
    {
        AddJointCollider(bodyParts.Head);
        AddJointCollider(bodyParts.LeftHand);
        AddJointCollider(bodyParts.RightHand);
    }

    private void AddJointCollider(GameObject parent)
    {
        GameObject jointSphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        jointSphere.transform.position = parent.transform.position;
        jointSphere.transform.parent = parent.transform;



    }
}
