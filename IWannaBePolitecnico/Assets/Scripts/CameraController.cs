using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject bg;
    public Vector3 dif;

    // Start is called before the first frame update
    void Start()
    {
        dif = transform.position - new Vector3(PlayerController.v3.x, 0, 0);
    }

    // LateUpdate is called once after update a frame
    void LateUpdate()
    {
        transform.position = PlayerController.v3 + dif;
        bg.transform.position = PlayerController.v3 + new Vector3(70,100,0);
    }
    
}
