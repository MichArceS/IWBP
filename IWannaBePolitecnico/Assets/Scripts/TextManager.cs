using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public Text tWelcome;
    private Vector3 vector;

    void Start()
    {
        vector = gameObject.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            tWelcome.transform.position = vector + new Vector3(0, 40, 0);
            tWelcome.text = "Welcome to the tutorial";
        }
    }
}
