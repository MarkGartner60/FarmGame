using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour

   
{
    public PlayerHP playerhp;
    public Player player;
   


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerhp = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHP>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, 10)*Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.CompareTag("Bullet"))
        {
            Destroy(transform.gameObject);
            Destroy(collision.transform.gameObject);
            player.Points += 1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Trigger"))
        {
            Destroy(transform.gameObject);
            playerhp.hp -= 1;

        }
    }
}
