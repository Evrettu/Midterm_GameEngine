using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int dmg;
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            ScoreManager.instance.ChangeHealth(dmg);
        }

        if (other.collider.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}
