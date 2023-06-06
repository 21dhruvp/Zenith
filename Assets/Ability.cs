using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Ability : MonoBehaviour
{
    private float _damage;

    public void UseAbility(in Stats stats)
    {
        _damage = stats.strength * 13; // Placeholder
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {  
        Debug.Log("Ability Triggered Damage");
        gameObject.GetComponentInParent<Reaction>().TakeDamage(_damage);
    }
}
