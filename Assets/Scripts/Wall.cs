using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public void OnPlayerHit()
    {
        Debug.Log("Player has been hit");
    }

    public void Update() {
	    //Debug.Log(transform.position.z);
	    if (-11 <= transform.position.z && transform.position.z <= -10) {
		    Debug.Log("low!");
		    MyGameUI.score += .27;
	    }
    }
}

