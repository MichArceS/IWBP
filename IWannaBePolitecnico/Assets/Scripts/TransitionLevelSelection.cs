using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionLevelSelection : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && gameObject.transform.name == "Tuturial")
        {
            SceneManager.LoadScene("Tutorial");
        }

        if (Input.GetMouseButtonDown(0) && gameObject.transform.name == "Stage1_1" +
            "")
        {
            SceneManager.LoadScene("Stage1_1");
        }
    }
}
