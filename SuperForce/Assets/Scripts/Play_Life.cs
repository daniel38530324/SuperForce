using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Life : MonoBehaviour
{
    public static int Life_Num =10;
    public GameObject Game_Fail_UI;
    public GameObject Game_Finish_UI;

    // Start is called before the first frame update
    void Start()
    {
        Life_Num = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (Life_Num <= 0)
        {
            Game_Fail_UI.SetActive(true);
            //SceneManager.LoadScene("Game_Start");
        }

    }

   
}
