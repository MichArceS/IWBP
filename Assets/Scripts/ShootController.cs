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
        if (Input.GetKeyUp(KeyCode.Space) && PlayerController.isRight)
        {
            Instantiate(shootPrefab,pos,q);
        }
        if (Input.GetKeyUp(KeyCode.Space) && !PlayerController.isRight)
        {
            Instantiate(shootPrefabLeft, pos, q);
        }
    }
}
