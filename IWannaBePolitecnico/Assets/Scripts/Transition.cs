using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Transition : MonoBehaviour
{
    public Text text1;
    public Text text2;
    int cont;

    private void Start()
    {
        cont = 0;
    }

    private void OnMouseDown()
    {
        if (gameObject.transform.name == "Start" && cont == 0)
        {
            SceneManager.LoadScene("Tutorial");
        }
        if (gameObject.transform.name == "LevelS" && cont == 0)
        {
            text1.text = "Tutorial";
            text2.text = "Stage 1";
            cont++;
        }
        if (gameObject.transform.name == "Start" && cont == 1)
        {
            SceneManager.LoadScene("Tutorial");
        }
        if (gameObject.transform.name == "LevelS" && cont == 1)
        {
            SceneManager.LoadScene("Stage1_1");
        }
    }
}
