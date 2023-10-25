using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHero: MonoBehaviour
{
    public float speed;
    public Transform limitH;
    public MouvementEtTir myPlayer;
    private Rigidbody2D rgbd;

    /*private ScoreManager scoreManager;*/

    // Start is called before the first frame update
    void Start()
    {
        rgbd = gameObject.GetComponent<Rigidbody2D>();
        rgbd.velocity = Vector3.up*speed;

        /*scoreManager = FindObjectOfType<ScoreManager>();*/
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*Opponent oponentCollider = collision.gameObject.GetComponent<Opponent>();
        if (oponentCollider)
        {
                scoreManager.score++;
            Destroy(oponentCollider.gameObject);
            
        }*/
        Destroy(gameObject);

    }
    void Update()
    {
    }

}
 