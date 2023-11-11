using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameBodyManager : MonoBehaviour
{
    public BodySourceView bodySourceView;

    private void OnEnable() {
        bodySourceView.OnBodyCreated += CreateBody;
    }

    private void CreateBody(BodyParts bodyParts)
    {
        Debug.Log("DOES THIS DEBUG LOG WORK");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
