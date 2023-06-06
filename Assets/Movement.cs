using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class Movement : MonoBehaviour
{
    private Vector2 _velocity;

    public void SetVelocity(Vector2 vel)
    {
        _velocity = vel;
    }
    // Update is called once per frame
    void Update()
    {
        Rigidbody2D currObject = gameObject.GetComponent<Rigidbody2D>();
        currObject.velocity = _velocity;
    }
}
