using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    public static Vector3 checkpointPosition;
    // Start is called before the first frame update
    void Start()
    {
        checkpointPosition = PlayerController.v3;
    }
}
