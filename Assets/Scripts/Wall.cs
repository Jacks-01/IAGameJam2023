using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public float zKillDistance;
    public void OnPlayerHit()
    {
        Debug.Log("Player has been hit");
    }

    public void Update() {
	    //Debug.Log(transform.position.z);
	

        if (transform.position.z <= zKillDistance) {
           Debug.Log("low!");
           MyGameUI.score += 1;
            
            Destroy(gameObject);
        }
    }
}

