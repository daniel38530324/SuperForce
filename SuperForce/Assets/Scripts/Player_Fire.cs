using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Fire : MonoBehaviour
{
    public Rigidbody Bullet;
    public int Throw_Z = 30;
    public int Throw_Y = 2;
    public GameObject Fire_Particle;
    public AudioClip Fire_Sound;   



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Game_State.State == true) { 
            if (Input.GetMouseButtonDown(0))
            {
                Rigidbody Grnade = Instantiate(Bullet, transform.position, transform.rotation);
                Grnade.velocity = transform.TransformDirection(new Vector3(0, Throw_Y, Throw_Z));
                Instantiate(Fire_Particle, transform.position, transform.rotation);
                GetComponent<AudioSource>().PlayOneShot(Fire_Sound);
            }
        }
    }
}
