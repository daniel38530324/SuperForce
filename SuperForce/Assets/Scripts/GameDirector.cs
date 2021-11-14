using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public GameObject p1, p2;
    // Start is called before the first frame update
    void Start()
    {
        if(choseCar.car1 == true)
        {
            p1.SetActive(true);
            p2.SetActive(false);
        }
        else if (choseCar.car2 == true)
        {
            p1.SetActive(false);
            p2.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
