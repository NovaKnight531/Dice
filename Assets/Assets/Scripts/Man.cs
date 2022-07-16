using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Man : MonoBehaviour
{
    private float turnTimer = 11f;
    private float turnTimer2 = 0.5f;
    private float turnTimer3 = 0.5f;

    public SpriteRenderer sr;

    public Sprite normal;
    public Sprite about;
    public Sprite turned;

    // Start is called before the first frame update
    void Start()
    {
        sr.sprite = normal;
    }

    // Update is called once per frame
    void Update()
    {
        turnTimer -= Time.deltaTime;

        if(turnTimer <= 0)
        {
            sr.sprite = about;

            turnTimer2 -= Time.deltaTime;

            if(turnTimer2 <= 0)
            {
                sr.sprite = turned;

                turnTimer3 -= Time.deltaTime;

                if(turnTimer3 <= 0)
                {
                    sr.sprite = normal;

                    turnTimer = 19f;
                    turnTimer2 = 0.5f;
                    turnTimer3 = 0.5f;
                }
            }
        }
    }
}
