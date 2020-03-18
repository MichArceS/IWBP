using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1Controller : MonoBehaviour
{
    bool alive;
    int lifePoints;
    float timer1;
    float timer2;
    float timer3;
    public static bool startTimer;
    Quaternion q = new Quaternion();
    
    Vector3 sawPositionX1 = new Vector3(6702, -300f, 0);
    Vector3 sawPositionX2 = new Vector3(6900, -300f, 0);
    Vector3 sawPositionX3 = new Vector3(7099, -300f, 0);

    public GameObject shootsPrefeb;
    public GameObject sawPrefab;
    public GameObject sawDownPrefab;

    bool shooting;
    bool firstF;
    bool secondF;
    bool finalF;
    bool finalF1;
    bool finalF2;
    bool idle;
    // Start is called before the first frame update
    void Start()
    {
        alive = true;
        finalF1 = true;
        finalF2 = false;
        shooting = false;
        idle = false;
        firstF = true;
        secondF = false;
        finalF = false;
        startTimer = false;
        lifePoints = 100;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = transform.position - new Vector3(0,15,0);
        if (startTimer)
        {
            Debug.Log(lifePoints);
            timer1 += Time.deltaTime;
            timer2 += Time.deltaTime;
            timer3 += Time.deltaTime;
            if (!alive)
            {
                gameObject.GetComponent<Animator>().SetBool("leftShoot", false);
                gameObject.GetComponent<Animator>().SetBool("move", false);
                gameObject.GetComponent<Animator>().SetBool("death", true);
                if (timer1 > 3)
                {
                    Destroy(gameObject);
                }
            }
            if (idle)
            {
                gameObject.GetComponent<Animator>().SetBool("move", true);
                if (lifePoints > 30 && lifePoints <= 69)
                {
                    secondF = true;
                    idle = false;
                }
                if (lifePoints > 0 && lifePoints <= 29)
                {
                    finalF = true;
                    idle = false;
                }
            }
            if (firstF)
            {
                if (timer1 <= 3f)
                {
                    gameObject.GetComponent<Animator>().SetBool("move", true);
                }
                if (timer1 > 3f)
                {
                    gameObject.GetComponent<Animator>().SetBool("move", false);
                    gameObject.GetComponent<Animator>().SetBool("leftShoot", true);
                }

                if (lifePoints > 70 && lifePoints <= 100)
                {
                    if (timer2 > 0.6f && timer1 > 3f)
                    {
                        Instantiate(shootsPrefeb, v, q);
                        timer2 = 0;
                    }
                }
                
                if (lifePoints <= 70)
                {
                    gameObject.GetComponent<Animator>().SetBool("leftShoot", false);
                    firstF = false;
                    secondF = true;
                    timer1 = 0; ;
                    timer2 = 0;
                }
            }
            if (secondF)
            {
                if (lifePoints > 0 && lifePoints <= 29)
                {
                    shooting = false;
                    gameObject.GetComponent<Animator>().SetBool("shoots", false);
                    gameObject.GetComponent<Animator>().SetBool("upShoot", false);
                    secondF = false;
                    idle = true;
                    timer1 = 0;
                    timer2 = 0;
                    timer3 = 0;
                }
                if (timer1 <= 3f)
                {
                    gameObject.GetComponent<Animator>().SetBool("move", true);
                }
                if (timer1 > 3f)
                {
                    if (shooting)
                    {
                        if (timer3 > 0.6)
                        {
                            Instantiate(sawPrefab, v, q);
                            timer3 = 0;
                            float n = Random.Range(0, 3);
                            if (n >= 0f && n < 1f)
                            {
                                Instantiate(sawDownPrefab, sawPositionX1, q);
                            }
                            if (n >= 1f && n < 2f)
                            {
                                Instantiate(sawDownPrefab, sawPositionX2, q);
                            }
                            if (n >= 2f && n < 3f)
                            {
                                Instantiate(sawDownPrefab, sawPositionX3, q);
                            }
                        }
                    }
                    gameObject.GetComponent<Animator>().SetBool("move", false);
                    gameObject.GetComponent<Animator>().SetBool("upShoot", true);
                    if (timer2 > 3f)
                    {
                        gameObject.GetComponent<Animator>().SetBool("shoots", true);
                        shooting = true;
                    }
                    if (timer2 > 10f && timer2 < 11f)
                    {
                        shooting = false;
                        gameObject.GetComponent<Animator>().SetBool("shoots", false);
                        gameObject.GetComponent<Animator>().SetBool("upShoot", false);
                        timer1 = 0;
                        timer2 = 0;
                        timer3 = 0;
                        secondF = false;
                        idle = true;
                    }
                }
            }
            if (finalF)
            {
                if (lifePoints <= 0)
                {
                    alive = false;
                    shooting = false;
                    gameObject.GetComponent<Animator>().SetBool("shoots", false);
                    gameObject.GetComponent<Animator>().SetBool("upShoot", false);
                    timer1 = 0;
                    timer2 = 0;
                    timer3 = 0;
                    finalF = false;
                    idle = false;
                }
                if (finalF1)
                {
                    if (timer1 <= 1f)
                    {
                        gameObject.GetComponent<Animator>().SetBool("move", true);
                    }
                    if (timer1 > 1f)
                    {
                        if (shooting)
                        {
                            if (timer3 > 0.6)
                            {
                                Instantiate(sawPrefab, v, q);
                                timer3 = 0;
                                float n = Random.Range(0, 3);
                                if (n >= 0f && n < 1f)
                                {
                                    Instantiate(sawDownPrefab, sawPositionX1, q);
                                }
                                if (n >= 1f && n < 2f)
                                {
                                    Instantiate(sawDownPrefab, sawPositionX2, q);
                                }
                                if (n >= 2f && n < 3f)
                                {
                                    Instantiate(sawDownPrefab, sawPositionX3, q);
                                }
                            }
                        }
                        gameObject.GetComponent<Animator>().SetBool("move", false);
                        gameObject.GetComponent<Animator>().SetBool("upShoot", true);
                        if (timer2 > 1f)
                        {
                            gameObject.GetComponent<Animator>().SetBool("shoots", true);
                            shooting = true;
                        }
                        if (timer2 > 8f && timer2 < 11f)
                        {
                            shooting = false;
                            gameObject.GetComponent<Animator>().SetBool("shoots", false);
                            gameObject.GetComponent<Animator>().SetBool("upShoot", false);
                            timer1 = 0;
                            timer2 = 0;
                            timer3 = 0;
                            finalF1 = false;
                            finalF2 = true;
                        }
                    }
                }

                if (finalF2)
                {
                    if (timer1 < 0.6)
                    {
                        gameObject.GetComponent<Animator>().SetBool("move", false);
                        gameObject.GetComponent<Animator>().SetBool("leftShoot", true);
                    }

                    if (timer2 > 0.6f)
                    {
                        Instantiate(shootsPrefeb, v, q);
                        timer2 = 0;
                    }
                    if (timer1 > 9 && timer1 < 11)
                    {
                        gameObject.GetComponent<Animator>().SetBool("leftShoot", false);
                        finalF = false;
                        finalF1 = true;
                        finalF2 = false;
                        idle = true;
                    }
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("shoot"))
        {
            lifePoints--;
        }
    }
}
