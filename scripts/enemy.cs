using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject DeathEffect;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("fire"))
        {
            GameObject death_effect= Instantiate(DeathEffect, transform.position, transform.rotation);
            SoundManager.playsound("explosion");
            Destroy(gameObject);
            Destroy(death_effect, 0.5f);
        }
    }
}
