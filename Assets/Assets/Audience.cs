using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audience : MonoBehaviour
{

    public SpriteRenderer sr;

    public Sprite normal;
    public Sprite vase;

    public float throwTimer = 10f;
    public float throwTimer2 = 1f;

    // Start is called before the first frame update
    void Start()
    {
        sr.sprite = normal; 
    }

    // Update is called once per frame
    void Update()
    {
        throwTimer -= Time.deltaTime;

        if(throwTimer <= 0)
        {
            sr.sprite = vase;

            throwTimer2 -= Time.deltaTime;

            if(throwTimer2 <= 0)
            {
                sr.sprite = normal;
                throwTimer = 19f;
                throwTimer2 = 1f;
            }
        }
    }
}
