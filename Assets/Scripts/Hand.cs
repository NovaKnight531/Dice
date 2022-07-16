using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    private Animator animator;

    private float bopTimer = 0.5f;
    private float slamWaitTimer = 1f;
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bopTimer -= Time.deltaTime;
        if(Input.GetButtonDown("Fire1") == true)
        {
            animator.SetBool("Slammed", true);
        }
        if (animator.GetBool("Slammed") == true)
        {
            slamWaitTimer -= Time.deltaTime;
            if (bopTimer <= 0 && slamWaitTimer <= 0)
            {
                slamWaitTimer = 1f;
                animator.SetBool("Slammed", false);
            }
        }
        if (bopTimer <= 0)
        {
            bopTimer = 0.5f;
        }
        
    }
}
