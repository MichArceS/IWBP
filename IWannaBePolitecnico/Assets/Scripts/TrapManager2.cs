using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapManager2 : MonoBehaviour
{
    public GameObject spike;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            spike.SetActive(true);
        }
    }
}
