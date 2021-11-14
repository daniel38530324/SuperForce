using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choseCar : MonoBehaviour
{
    public static bool car1, car2;
    // Start is called before the first frame update
    void Start()
    {
        car1 = false;
        car2 = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void camera1()
    {
        GetComponent<Animator>().SetTrigger("change3");
        car1 = false;
        car2 = true;
    }

    public void camera2()
    {
        GetComponent<Animator>().SetTrigger("change2");
        car1 = true;
        car2 = false;
    }
}
