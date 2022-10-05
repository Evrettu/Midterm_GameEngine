using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int score = 0;
    public int Health = 10;
    public int final = 0;
    public static ScoreManager finalscore;

    private string scoretxt = "Score is";
    private string Finalscoretxt = "Final score is";
    private string hptxt = "Health is";
    // Start is called before the first frame update
    void Awake()
    {
        if(!instance)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScore(int coinvalue)
    {
        score += coinvalue;
        Debug.Log(scoretxt);
        Debug.Log(score);
    }

    public void ChangeHealth(int dmg)
    {
        Health -= dmg;
        Debug.Log(hptxt);
        Debug.Log(Health);
    }

    public void RaiseHealth(int hp)
    {
        Health += hp;
        Debug.Log(hptxt);
        Debug.Log(Health);
    }

    public void FinalScore()
    {
       if(Health >= 10)
        {
            final = (score * Health);
        }

       if(Health < 10 && Health >= 5)
        {
            final = (score * (Health / 2));
        }

       if(Health >= 1 && Health < 5)
        {
            final = score;
        }

       if(Health <= 0)
        {
            final = (score * (Health / 2) / 2);
        }
        

        Debug.Log(Finalscoretxt);
        Debug.Log(final);
    }
}
