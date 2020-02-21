using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBoxController : MonoBehaviour
{
    public static bool move;
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
            gameObject.GetComponent<Animator>().SetBool("Move", true);
        }
        if (!move)
        {
            gameObject.GetComponent<Animator>().SetBool("Move", false);
            transform.position = v;
        }
                
    }
}
