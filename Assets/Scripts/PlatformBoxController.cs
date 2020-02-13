using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBoxController : MonoBehaviour
{
    public static bool move = false;
    bool idle = true;

    void Update()
    {
        if (idle)
        {
            if (move)
            {
                gameObject.GetComponent<Animator>().SetBool("Move", true);
            }
        }
                
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            Vector3 a = collision.gameObject.transform.position;
            float x = PlayerController.v3.x;
            collision.gameObject.transform.position = new Vector3(x,gameObject.transform.position.y + 21.5f,0);
        }
    }
}
