using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFreezer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            CameraController.freeze = true;
        }
    }
}
