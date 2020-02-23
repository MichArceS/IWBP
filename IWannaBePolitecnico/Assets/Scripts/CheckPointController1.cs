using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CheckPointController1 : MonoBehaviour
{
    public GameObject turtle;

    void Start()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            CheckPointManager.checkpointPosition = gameObject.transform.position + new Vector3(0, 30, 0);
            turtle.SetActive(true);
            Destroy(gameObject);
            Debug.Log(SceneManager.GetActiveScene().name);
        }
        
    }
}
