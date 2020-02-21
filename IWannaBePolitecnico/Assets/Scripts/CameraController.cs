using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject bg;
    

    // Start is called before the first frame update
    void Start()
    {
    }

    // LateUpdate is called once after update a frame
    void LateUpdate()
    {
        transform.position = PlayerController.v3 + CheckPointManager.dif;
        bg.transform.position = PlayerController.v3 + new Vector3(70,100,0);
    }
    
}
