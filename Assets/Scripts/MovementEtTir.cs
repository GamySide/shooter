using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MouvementEtTir : MonoBehaviour
{
    public GameObject bullet;
    public Transform parent;
    public Transform limitL;
    public Transform limitR;
    public int destroyedBullet;
    public int i = 0;
    public TextMeshProUGUI healthText;

    public float speed = 1f;
    int hp = 5;
    private ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left*speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.position += Vector3.right*speed;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            i+=1;
            if (i == 10)
            {
               GameObject createdBullet = Instantiate(bullet, parent.position, parent.rotation);
               createdBullet.GetComponent<BulletHero>().myPlayer = this;
                i = 0;
            }
            
        }
        

        if (transform.position.x < limitL.position.x)
        {
            transform.position = new Vector3(limitL.position.x, transform.position.y, transform.position.z);
        }
        if (transform.position.x > limitR.position.x)
        {
            transform.position = new Vector3(limitR.position.x, transform.position.y, transform.position.z);
        }
        healthText.text ="health :" + hp.ToString("000");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("coucou");
        BulletEnnemi bulletCollider = collision.gameObject.GetComponent<BulletEnnemi>();
        if (bulletCollider)
        {
 
            hp -= 1;
            scoreManager.score = scoreManager.score - 10;
        }
        if (hp == 0)
        {
            scoreManager.score = 0;
            Destroy(gameObject);
            
        }
    }
}
