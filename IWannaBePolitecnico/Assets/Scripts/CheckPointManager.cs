using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    public GameObject cam;
    private static CheckPointManager cm;
    public static Vector3 checkpointPosition;
    public static Vector3 dif;
    // Start is called before the first frame update
    void Start()
    {
            dif = cam.transform.position - checkpointPosition;
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
