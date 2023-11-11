using UnityEngine;
using System.Collections;

public class StartGamecollider : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // ContactPoint contact = collision.contacts[0];
        // Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
        // Vector3 position = contact.point;
        // Instantiate(explosionPrefab, position, rotation);
        // Destroy(gameObject);

        Debug.Log("collided!");
    }
}