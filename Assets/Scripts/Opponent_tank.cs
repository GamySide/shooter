using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentTank: MonoBehaviour
{
    int hp = 30;
    private ScoreManager scoreManager;
    



    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        BulletHero bulletCollider = collision.gameObject.GetComponent<BulletHero>();
        if (bulletCollider)
        {
            hp -= 1;
        }
        if(hp == 0)
        {
            scoreManager.score += 10;
            Destroy(gameObject);
        }
    }

}
