using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour

{
    private GameInfo gameinfo;
    public GameObject Cow;
    // Start is called before the first frame update
    void Start()
    {
        gameinfo = GameObject.FindGameObjectWithTag("Player").GetComponent<GameInfo>();
        StartCoroutine(Spawner());
    }

    IEnumerator Spawner()
    {

        while (true)
        { 
            if (gameinfo.isgameon == true)
            {
                 Instantiate(Cow, new Vector3(Random.Range(-21, 21.0f), 0, 22), Quaternion.Euler(0,180,0), transform);
            }
                yield return new WaitForSeconds(4);
        }

               
       
    }

    public void DeleteCow()
    {
         for (int npccounter=transform.childCount-1;npccounter>=0;npccounter--)
        {
            Destroy(transform.GetChild(npccounter).gameObject);
        }
    }
}