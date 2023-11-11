using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PressableButton : MonoBehaviour
{
    public UnityEvent OnButtonPress;

    public void OnCollisionEnter(Collision other)
    {
        OnButtonPress?.Invoke();
    }

    public void OnTriggerEnter(Collider other)
    {
        OnButtonPress?.Invoke();
    }
}
