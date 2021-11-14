using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Bullet_Collision : MonoBehaviour
{
    public GameObject Smoke;
    public float MoveSpeed = 30;
    public float Destroy_Time = 1.5f;
    public AudioClip HitSound;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, Destroy_Time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(Smoke, transform.position, transform.rotation);
        if (collision.gameObject.tag == "Player")
        {
            Play_Life.Life_Num -= 1;
            GetComponent<AudioSource>().PlayOneShot(HitSound);
        }
        Destroy(gameObject,0.6f);
    
    }
}
