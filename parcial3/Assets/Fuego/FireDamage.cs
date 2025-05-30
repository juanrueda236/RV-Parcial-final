using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// FireDamage.cs
using UnityEngine;

public class FireDamage : MonoBehaviour
{
    public float damagePerSecond = 10f;

    private void OnTriggerStay(Collider other)
    {
        PlayerHealth player = other.GetComponent<PlayerHealth>();
        if (player != null)
        {
            player.TakeDamage(damagePerSecond * Time.deltaTime);
        }
    }
}
