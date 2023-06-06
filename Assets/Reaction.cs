using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Reaction : MonoBehaviour
{
    public void TakeDamage(float received)
    {
        // TODO: Take damage based on armor/mr
        gameObject.GetComponent<Stats>().vitality -= received;
        
    }

}
