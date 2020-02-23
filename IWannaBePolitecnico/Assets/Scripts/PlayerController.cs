﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public GameObject cam;
    public static bool jump = false;
    public static Vector3 v3;
    public static bool isRight = true;
    public static bool alive;
    public Text DT;
    public Text RT;
    public static Vector3 dif;

    // Update is called once per frame
    void Start()
    {
        dif = cam.transform.position - transform.position;
        alive = true;
        v3 = transform.position;
        gameObject.transform.position  = CheckPointManager.checkpointPosition;
    }
    void Update()
    {
        v3 = transform.position;
        if (alive)
        {
            if (!jump)
            {
                gameObject.GetComponent<Animator>().SetBool("jump", true);
            }
            if (Input.GetKey("left") && jump)
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-18000f * Time.deltaTime, 0));
                isRight = false;
                gameObject.GetComponent<Animator>().SetBool("move", true);
            }
            if (Input.GetKey("right") && jump)
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(18000f * Time.deltaTime, 0));
                isRight = true;
                gameObject.GetComponent<Animator>().SetBool("move", true);
            }
            if (Input.GetKey("left") && !jump)
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-18000f * Time.deltaTime, 0));
                isRight = false;
                gameObject.GetComponent<Animator>().SetBool("move", false);
                gameObject.GetComponent<Animator>().SetBool("jump", true);
            }
            if (Input.GetKey("right") && !jump)
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(18000f * Time.deltaTime, 0));
                isRight = true;
                gameObject.GetComponent<Animator>().SetBool("move", false);
                gameObject.GetComponent<Animator>().SetBool("jump", true);
            }
            if (Input.GetKeyDown("space") && jump)
            {
                gameObject.GetComponent<Animator>().SetBool("move", false);
                gameObject.GetComponent<Animator>().SetBool("jump", true);
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 6000f));
                gameObject.GetComponent<AudioSource>().Play();
                jump = false;
            }
            if (jump)
            {
                gameObject.GetComponent<Animator>().SetBool("jump", false);
            }
        }
        if (!alive)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                gameObject.GetComponent<Animator>().SetBool("move", false);
                alive = true;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                DT.text = "";
                RT.text = "";
            }
        }
        if (!Input.GetKey("left") && !Input.GetKey("right"))
        {
            gameObject.GetComponent<Animator>().SetBool("move", false);
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
            DT.transform.position = v3 + new Vector3(220,100,0);
            DT.text = "YOU DIED";
            RT.transform.position = v3 + new Vector3(220, 95, 0);
            RT.text = "Press R to restart";

        }
        if (collision.transform.tag == "moving crate")
        {
            if (v3.y > collision.transform.position.y + 28f)
            {
                jump = true;
                gameObject.transform.parent = collision.transform;
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "moving crate")
        {
            gameObject.transform.parent = null;
            jump = false;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag == "Platform" || collision.transform.tag == "crate")
        {
            jump = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "acid")
        {
            alive = false;
            DT.transform.position = v3 + new Vector3(220, 100, 0);
            DT.text = "YOU DIED";
            RT.transform.position = v3 + new Vector3(220, 95, 0);
            RT.text = "Press R to restart";
        }
    }
}
