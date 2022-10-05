using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public int score;
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            ScoreManager.instance.ChangeScore(score);
            Destroy(gameObject);
        }
    }
}
