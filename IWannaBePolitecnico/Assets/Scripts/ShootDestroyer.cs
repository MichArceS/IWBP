using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootDestroyer : MonoBehaviour
{
    float timer = 0;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0.5f)
        {
            Destroy(transform.parent.gameObject);
        }
           
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "enemy")
        {
            Destroy(transform.parent.gameObject);
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("boss"))
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
