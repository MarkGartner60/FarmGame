using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour

    
{
    public float speed;
    public float move;
    public GameObject food;
    public int Points;
    public TextMeshProUGUI screenpoints;
    private GameInfo gameinfo;



    // Start is called before the first frame update
    void Start()
    {
        gameinfo = GameObject.FindGameObjectWithTag("Player").GetComponent<GameInfo>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (gameinfo.isgameon == false)
        {
            return;
        }
       
        move =Input.GetAxis("Horizontal");
            transform.Translate(Vector3.left*Time.deltaTime*speed*move);

        if(transform.position.x>22)
        {
            transform.position = new Vector3(22, 0, -5.1f);
        }

        if(transform.position.x < -22)
        {
            transform.position = new Vector3(-22, 0, -5.1f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(food,transform.position,food.transform.rotation);

        }
        screenpoints.text = Points.ToString();


    }
   
}
