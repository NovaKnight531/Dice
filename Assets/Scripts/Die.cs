using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{

    private float waitTimer = 10f;
    private float rollTimer = 2f;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        waitTimer -= Time.deltaTime;

        if(waitTimer <= 0)
        {
            animator.SetBool("Rolling", true);
            rollTimer -= Time.deltaTime;

            if(rollTimer <= 0)
            {
                animator.SetBool("Rolling", false);
                waitTimer = 18f;
                rollTimer = 2f;
            }
        }
    }
}
