using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{

    private float waitTimer = 10f;
    private float rollTimer = 2f;

    public int number;
    public Sprite[] face;
    public SpriteRenderer sr;

    public Animator animator;

    private bool facePicked = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();

        number = Random.Range(0, face.Length);
        
    }

    // Update is called once per frame
    void Update()
    {
        sr.sprite = face[number];

        waitTimer -= Time.deltaTime;

        if(waitTimer <= 0)
        {
            if(facePicked == false)
            {
                number = Random.Range(0, face.Length);
                facePicked = true;
            }
            
            animator.SetBool("Rolling", true);
            rollTimer -= Time.deltaTime;

            if(rollTimer <= 0)
            {
                animator.SetBool("Rolling", false);
                
                waitTimer = 18f;
                rollTimer = 2f;
                facePicked = false;
            }
        }
    }
}
