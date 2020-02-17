using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController2 : MonoBehaviour
{
    public static bool move = false;
    bool idle = true;

    void Update()
    {
        if (idle)
        {
            if (move)
            {
                gameObject.GetComponent<Animator>().SetBool("move", true);
            }
        }

    }
}
