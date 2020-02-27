﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxOnOff_1 : MonoBehaviour
{
    float timer;
    bool active;

    // Start is called before the first frame update
    void Start()
    {
        active = true;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 4f && active)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            active = false;
            timer = 0;
        }
        if (timer >= 4f && !active)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
            gameObject.SetActive(true);
            active = true;
            timer = 0;
        }
    }
}
