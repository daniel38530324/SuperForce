using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Bullet_Move : MonoBehaviour
{
    public GameObject Smoke;
    public float MoveSpeed = 30;
    public float Destroy_Time = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, Destroy_Time);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0*Time.deltaTime, 0 * Time.deltaTime, MoveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(Smoke, transform.position, transform.rotation);
        if (collision.gameObject.tag == "Enemy_Car" || collision.gameObject.tag == "Enemy_Tank" || collision.gameObject.tag == "Rock")
        {
           Destroy(collision.gameObject, 0.3f);
        }
        if(collision.gameObject.tag == "Enemy_Helicopter")
        {
            Enemy_Helicopter.hp -= 1;
        }
        Destroy(gameObject);
    
    }
}
