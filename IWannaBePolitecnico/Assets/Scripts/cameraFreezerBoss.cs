using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFreezerBoss : MonoBehaviour
{
    public GameObject cam;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            Boss1Controller.startTimer = true;
            CameraController.freeze = true;
            cam.transform.position = transform.position + new Vector3(90, 0, 0);
            Destroy(gameObject);
        }
    }
}
