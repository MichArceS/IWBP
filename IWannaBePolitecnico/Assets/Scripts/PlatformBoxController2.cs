using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBoxController2 : MonoBehaviour
{
    public static bool move = false;

    private void Start()
    {
        move = false;
    }
    void Update()
    {
        if (move)
        {
            gameObject.GetComponent<Animator>().SetBool("move", true);
        }
    }
}