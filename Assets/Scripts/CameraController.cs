using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 dif;

    // Start is called before the first frame update
    void Start()
    {
        dif = transform.position - PlayerController.v3;
    }

    // LateUpdate is called once after update a frame
    void LateUpdate()
    {
        transform.position = PlayerController.v3 + dif + new Vector3(0,75,0);
    }
}
