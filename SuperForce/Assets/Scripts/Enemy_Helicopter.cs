using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Helicopter : MonoBehaviour
{
    public GameObject Player, point;
    public Rigidbody Bullet_Source;
    public GameObject Fire_Point, Fire_Point2;
    public GameObject Fire_Particle;
    public GameObject Treasure, explode;
    public int Fire_Y = 5;
    public int Fire_Z = 30;
    public int Move_Dis_Num = 100;
    public int Fire_Dis_Num = 70;
    private float Dis;
    private float i;
    public static int hp = 5;

    // Start is called before the first frame update
    void Start()
    {
        hp = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Game_State.State == true)
        {
            Dis = Vector3.Distance(transform.position, Player.transform.position);
            if (Dis < Move_Dis_Num)
            {
                transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, 0.05f);
                transform.LookAt(Player.transform);
                Fire_Point.transform.LookAt(point.transform);
                Fire_Point2.transform.LookAt(point.transform);
                if (Dis < Fire_Dis_Num)
                {
                    i += Time.deltaTime;
                    if (i > 1f)
                    {
                        Instantiate(Fire_Particle, Fire_Point.transform.position, transform.rotation);
                        Rigidbody Bullet = Instantiate(Bullet_Source, Fire_Point.transform.position, Fire_Point.transform.rotation);
                        Bullet.velocity = transform.TransformDirection(new Vector3(0, Fire_Y, Fire_Z));

                        Instantiate(Fire_Particle, Fire_Point2.transform.position, transform.rotation);
                        Rigidbody Bullet2 = Instantiate(Bullet_Source, Fire_Point2.transform.position, Fire_Point2.transform.rotation);
                        Bullet2.velocity = transform.TransformDirection(new Vector3(0, Fire_Y, Fire_Z));
                        i = 0;
                    }
                }
            }
        }

        if(hp <= 0)
        {
            Instantiate(explode, transform.position, transform.rotation);
            Instantiate(Treasure, transform.position, Quaternion.Euler(-90,0,90));
            Destroy(gameObject);
        }
    }
}
