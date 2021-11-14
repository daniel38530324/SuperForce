using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw_Grnade : MonoBehaviour
{
    public Rigidbody Grnade_Source;
    public int Throw_Z=30;
    public int Throw_Y = 2;
    public AudioClip Throw_Sound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Game_State.State == true)
        {
            if (Input.GetMouseButtonDown(1))
            {
                Rigidbody Grnade = Instantiate(Grnade_Source, transform.position, transform.rotation);
                Grnade.velocity = transform.TransformDirection(new Vector3(0, Throw_Y, Throw_Z));
                GetComponent<AudioSource>().PlayOneShot(Throw_Sound);
            }
        }
    }
}
