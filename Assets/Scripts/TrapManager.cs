using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrapManager : MonoBehaviour
{
    public Text tTrap;
    // Start is called before the first frame update
    void Start()
    {
        tTrap.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            tTrap.text = "Be careful with the traps... ";
        }
    }
}
