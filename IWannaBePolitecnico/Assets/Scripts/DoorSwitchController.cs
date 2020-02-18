using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitchController : MonoBehaviour
{
    public GameObject switch1;
    private bool show;
    private bool activate;
    private bool a;

    // Start is called before the first frame update
    void Start()
    {
        a = false;
    }

    void Update()
    {
        if (a)
        {
            Destroy(gameObject);
            switch1.SetActive(true);
            DoorController.move = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "shoot")
        {
            a = true;
        }
    }
}
