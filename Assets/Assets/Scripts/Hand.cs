using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    private Animator animator;

    private float bopTimer = 0.499f;
    private float slamWaitTimer = 1f;

    private GameObject die;
    private Die dieScript;
    void Start()
    {
        die = GameObject.FindGameObjectWithTag("Die");
        dieScript = die.GetComponent<Die>();

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
            if(dieScript.animator.GetBool("Rolling") == true)
            {
                dieScript.number = 0;
            }


            slamWaitTimer -= Time.deltaTime;
            if (bopTimer <= 0 && slamWaitTimer <= 0)
            {
                slamWaitTimer = 1f;
                animator.SetBool("Slammed", false);
            }
        }
        if (bopTimer <= 0)
        {
            bopTimer = 0.499f;
        }
        
    }
}
