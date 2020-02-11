using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootDestroyer : MonoBehaviour
{
    float timer = 0;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0.5f)
        {
            Destroy(transform.parent.gameObject);
            timer = 0;
        }
        
    }
}
