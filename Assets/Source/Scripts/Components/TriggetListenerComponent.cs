using System;
using UnityEngine;

public class TriggetListenerComponent : MonoBehaviour
{
    public event Action<Transform> OnTriggerEnterEvent;

    void OnTriggerEnter(Collider other)
    {
        OnTriggerEnterEvent?.Invoke(other.transform);
    }
}
