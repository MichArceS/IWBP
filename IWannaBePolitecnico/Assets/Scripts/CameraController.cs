using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour
{
    public GameObject bg;
    public static bool freeze;
    private Vector3 dif;
    

    // Start is called before the first frame update
    void Start()
    {
        dif = transform.position - PlayerController.v3;
        freeze = false;
    }

    // LateUpdate is called once after update a frame
    void LateUpdate()
    {
        if (!freeze)
        {
            if (SceneManager.GetActiveScene().name == "Tutorial")
            {
                transform.position = PlayerController.v3 + PlayerController.dif - new Vector3(0, 50f, 0);
                bg.transform.position = PlayerController.v3 + new Vector3(70, 100, 0);
            }
            if (SceneManager.GetActiveScene().name == "Stage1_1")
            {
                transform.position = PlayerController.v3 + PlayerController.dif;
                bg.transform.position = PlayerController.v3 + new Vector3(70, 100, 0);
            }
        }
    }
}
