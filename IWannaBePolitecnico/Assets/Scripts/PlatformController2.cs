using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController2 : MonoBehaviour
{
    public static bool move = false;
    private Vector3 v;

    private void Start()
    {
        v = transform.position;
        move = false;
    }
    void Update()
    {
        if (move)
        {
            gameObject.GetComponent<Animator>().SetBool("move", true);
        }
        if (!move)
        {
            gameObject.GetComponent<Animator>().SetBool("move", false);
            transform.position = v;
        }
    }
}
