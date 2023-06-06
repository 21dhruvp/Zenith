using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public GameObject[] abilities;
    public float vitality;
    public ushort strength;
    public ushort armor;
    public ushort magicResist;
    public ushort intelligence;
    public ushort dexterity;
    public byte level;

    public void UseAbility(int index)
    {
        // Tweak this maybe, want to spawn specific skill at specific point
        GameObject ability = Instantiate(abilities[index], this.transform);
        ability.GetComponent<Ability>().UseAbility(this.GetComponent<Stats>());
    }
}
