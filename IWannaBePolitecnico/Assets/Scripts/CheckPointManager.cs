using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    private static CheckPointManager cm;
    public static Vector3 checkpointPosition;
    public static Vector3 dif;

    void Start()
    {
        checkpointPosition = PlayerController.v3;    
    }
    void Awake()
    {
        if (cm == null)
        {
            cm = this;
            DontDestroyOnLoad(cm);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
