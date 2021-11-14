using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCollision : MonoBehaviour
{
    public GameObject win, magic, player;
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
        
        if (other.gameObject.tag == "L1")
        {
            player.transform.position = magic.transform.position;
            player.transform.rotation = magic.transform.rotation;
        }

        if (other.gameObject.tag == "ball")
        {
            win.SetActive(true);
        }

        if (other.gameObject.tag == "sea")
        {
            player.transform.position = new Vector3(413, 5.2f, 8.2f);
            player.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

}
