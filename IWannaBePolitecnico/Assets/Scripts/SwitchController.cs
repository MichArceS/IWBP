using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    public GameObject switch1;
    private bool show;
    private bool activate;
    private bool a;

    // Start is called before the first frame update
    void Start()
    {
        show = true;
        activate = false;
        a = false;
    }

    void Update()
    {
        if (activate)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                a = true;
            }
        }
            
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (show)
        {
            if (collision.transform.tag == "Player")
            {
                activate = true;
                if (a)
                {
                    gameObject.SetActive(false);
                    switch1.SetActive(true);
                    show = false;
                    PlatformBoxController.move = true;
                }
            }
        }
    }
}
