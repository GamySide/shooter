using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentShooter: MonoBehaviour
{
    public GameObject bulletEnnemi;
    int hp = 3;
    private ScoreManager scoreManager;
    public Transform parent;
    public int destroyedBullet;
    public int i = 0;




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
            scoreManager.score += 5;
            Destroy(gameObject);
        }
      
    }

    private void Update()
    {
        int randomNumberForShoot = Random.Range(0, 1000);
        if (randomNumberForShoot == 150)
        {
            GameObject createdEnnemiBullet = Instantiate(bulletEnnemi, parent.position, parent.rotation);
            createdEnnemiBullet.GetComponent<BulletEnnemi>().myEnnemi = this;
            i = 0;
        }
    }

}
