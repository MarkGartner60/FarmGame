using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour


{
    public int hp = 3;
    public Sprite heart;
    public Sprite noheart;
    public Image uiheart1;
    public Image uiheart2;
    public Image uiheart3;
    private GameInfo gameinfo;
    public GameObject losescreen;

    // Start is called before the first frame update
    void Start()
    {
        gameinfo = GameObject.FindGameObjectWithTag("Player").GetComponent<GameInfo>();
    }

    // Update is called once per frame
    void Update()
    {
        
        switch (hp)
        {
            case 3:
                uiheart1.sprite = heart;
                uiheart2.sprite = heart;
                uiheart3.sprite = heart;
                break;
            case 2:
                uiheart1.sprite = noheart;
                uiheart2.sprite = heart;
                uiheart3.sprite = heart;
                break;
            case 1:
                uiheart1.sprite = noheart;
                uiheart2.sprite = noheart;
                uiheart3.sprite = heart;
                break;
            case 0:
                uiheart1.sprite = noheart;
                uiheart2.sprite = noheart;
                uiheart3.sprite = noheart;
                gameinfo.isgameon = false;
                losescreen.SetActive(true);
                break;
        }

    }
    public void Showscreen()
    {
        losescreen.SetActive(false);
    }
    public void ResetHP()
    {
        hp = 3;
    }
}
