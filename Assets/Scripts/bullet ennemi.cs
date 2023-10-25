using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnnemi: MonoBehaviour
{
    public float speed;
    public Transform limitH;
    public OpponentShooter myEnnemi;
    private Rigidbody2D rgbd;

    /*private ScoreManager scoreManager;*/

    // Start is called before the first frame update
    void Start()
    {
        rgbd = gameObject.GetComponent<Rigidbody2D>();
        rgbd.velocity = Vector3.up*speed;

        /*scoreManager = FindObjectOfType<ScoreManager>();*/
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "Finish")
        {
            Destroy(gameObject);
        }
        /*Opponent oponentCollider = collision.gameObject.GetComponent<Opponent>();
        if (oponentCollider)
        {
                scoreManager.score++;
            Destroy(oponentCollider.gameObject);
            
        }*/

    }
    void Update()
    {
    }

}
 