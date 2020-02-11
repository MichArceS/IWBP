using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool jump = false;
    public static Vector3 v3;
    public static bool isRight = true;

    // Update is called once per frame
    void Update()
    {
        v3 = transform.position;
        if (Input.GetKey("left"))
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-18000f * Time.deltaTime, 0));
                isRight = false;
        }
        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(18000f * Time.deltaTime, 0));
            isRight = true;
        }
        if (Input.GetKey("up") && jump)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 5000f));
            jump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Platform")
        {
            jump = true;
        }
    }
}
