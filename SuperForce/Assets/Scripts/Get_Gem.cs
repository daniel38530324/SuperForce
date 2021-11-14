using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_Gem : MonoBehaviour
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
            GetGem_Total.Gem_Num += 1;
            GetComponent<AudioSource>().PlayOneShot(Get_Sound);
            Destroy(gameObject, 0.8f);
        }
    }
    
    
}
