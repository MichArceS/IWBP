using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    public GameObject shootPrefab;
    public GameObject shootPrefabLeft;
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = PlayerController.v3;
        Quaternion q = new Quaternion();
        if (shootPrefabLeft != null && Input.GetKeyDown(KeyCode.X) && !PlayerController.isRight)
        {
            Instantiate(shootPrefabLeft, pos, q);
        }
        if (shootPrefab != null && Input.GetKeyDown(KeyCode.X) && PlayerController.isRight)
        {
            Instantiate(shootPrefab,pos,q);
        }
        
    }
}
