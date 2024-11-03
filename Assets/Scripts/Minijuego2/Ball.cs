using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Ball : MonoBehaviour
{
    public static event Action OnDefeat;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Dead"))
        {
            OnDefeat?.Invoke();
        }
    }
}