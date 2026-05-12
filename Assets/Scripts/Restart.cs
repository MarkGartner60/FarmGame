using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    [SerializeField] private NPCSpawner npcspawner;
    public GameInfo isgameon;
    [SerializeField] private PlayerHP screen;
    public Player points;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGame()
    {
        npcspawner.DeleteCow();
        screen.Showscreen();
        screen.ResetHP();
        isgameon.isgameon = true;
        points.Points = 0;
    }
}
