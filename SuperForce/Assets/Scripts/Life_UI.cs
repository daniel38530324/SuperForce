using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life_UI : MonoBehaviour
{
    //public Image Show_Life_UI;
    //public Sprite[] Sprite_Texture;
    public Slider hp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Play_Life.Life_Num == 10)
        {
            //Show_Life_UI.sprite = Sprite_Texture[9];
            hp.value = 1;
        }

        if (Play_Life.Life_Num == 9)
        {
            //Show_Life_UI.sprite = Sprite_Texture[8];
            hp.value = 0.9f;
        }

        if (Play_Life.Life_Num == 8)
        {
            //Show_Life_UI.sprite = Sprite_Texture[7];
            hp.value = 0.8f;
        }

        if (Play_Life.Life_Num == 7)
        {
            //Show_Life_UI.sprite = Sprite_Texture[6];
            hp.value = 0.7f;
        }

        if (Play_Life.Life_Num == 6)
        {
            //Show_Life_UI.sprite = Sprite_Texture[5];
            hp.value = 0.6f;
        }

        if (Play_Life.Life_Num == 5)
        {
            //Show_Life_UI.sprite = Sprite_Texture[4];
            hp.value = 0.5f;
        }

        if (Play_Life.Life_Num == 4)
        {
            //Show_Life_UI.sprite = Sprite_Texture[3];
            hp.value = 0.4f;
        }

        if (Play_Life.Life_Num == 3)
        {
            //Show_Life_UI.sprite = Sprite_Texture[2];
            hp.value = 0.3f;
        }

        if (Play_Life.Life_Num == 2)
        {
            //Show_Life_UI.sprite = Sprite_Texture[1];
            hp.value = 0.2f;
        }

        if (Play_Life.Life_Num == 1)
        {
            //Show_Life_UI.sprite = Sprite_Texture[0];
            hp.value = 0.1f;
        }

        if (Play_Life.Life_Num == 0)
        {
            //Show_Life_UI.enabled= false;
            hp.value = 0;
        }

    }
}
