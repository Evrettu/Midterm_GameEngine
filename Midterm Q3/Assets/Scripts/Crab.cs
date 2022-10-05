using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            ScoreManager.instance.ChangeHealth(1);
        }

        if (other.collider.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}
