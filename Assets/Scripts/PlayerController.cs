using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static bool jump = false;
    public static Vector3 v3;
    public static bool isRight = true;
    public static bool alive;

    // Update is called once per frame
    void Start()
    {
        alive = true;    
    }
    void Update()
    {
        v3 = transform.position;
        if (alive)
        {
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
            if (Input.GetKeyDown("space") && jump)
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 6000f));
                jump = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Platform" || collision.transform.tag == "crate")
        {
            if (v3.y > collision.transform.position.y + 28f)
            {
                jump = true;
            }
        }
        if (collision.transform.tag == "spike")
        {
            alive = false;
        }
    }
}
