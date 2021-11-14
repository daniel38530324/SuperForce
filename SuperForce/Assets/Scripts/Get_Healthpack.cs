using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_Healthpack : MonoBehaviour
{
    public AudioClip Get_Sound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Play_Life.Life_Num < 10)
            {
                Play_Life.Life_Num += 1;
                print(Play_Life.Life_Num);
            }
            GetComponent<AudioSource>().PlayOneShot(Get_Sound);
            Destroy(gameObject, 0.8f);
        }
    }
}
