using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    public float DownAccel = 1;
    public float animConst = 0.05f;
    public float moveSpeed = 10;
    public float turnSpeed = 5;
    private Animator animator;
    private CharacterController charController;
    private float vertical = 0;
    private float horizontal = 0;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //charController.Move(Vector3.down * DownAccel * Time.deltaTime);
        //animator.SetFloat("Horizontal", 0);
        //animator.SetFloat("Vertical", 0);

        // Vertical movement
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            if (animator.GetFloat("Vertical") < 1.0f) animator.SetFloat("Vertical", animator.GetFloat("Vertical") + animConst);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            if (animator.GetFloat("Vertical") > 0.5f) animator.SetFloat("Vertical", animator.GetFloat("Vertical") - animConst);
            if (animator.GetFloat("Vertical") < 0.5f) animator.SetFloat("Vertical", animator.GetFloat("Vertical") + animConst);
            //if (vertical < 1.0f) vertical += animConst;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (animator.GetFloat("Vertical") > -1.0f) animator.SetFloat("Vertical", animator.GetFloat("Vertical") - animConst);
            //if (vertical > -1.0f) vertical -= animConst;
        }
        else
        {
            if (animator.GetFloat("Vertical") > 0) animator.SetFloat("Vertical", animator.GetFloat("Vertical") - animConst);
            else if (animator.GetFloat("Vertical") < 0) animator.SetFloat("Vertical", animator.GetFloat("Vertical") + animConst);

            if (animator.GetFloat("Vertical") < 0.02f && animator.GetFloat("Vertical") > -0.02f) animator.SetFloat("Vertical", 0);
            //if (vertical > 0) vertical -= animConst;
            //else if (vertical < 0) vertical += animConst;
        }

        //Horizontal movement
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetFloat("Horizontal", -1f);
            //if (animator.GetFloat("Horizontal") > -1.0f) animator.SetFloat("Horizontal", animator.GetFloat("Horizontal") - animConst);
            //if (horizontal > -1.0f) horizontal -= animConst;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            //if (horizontal < 1.0f) horizontal += animConst;
            animator.SetFloat("Horizontal", 1f);
            //if (animator.GetFloat("Horizontal") < 1.0f) animator.SetFloat("Horizontal", animator.GetFloat("Horizontal") + animConst);
        }
        else
        {
            animator.SetFloat("Horizontal", 0);
            //if (horizontal > 0) horizontal -= animConst;
            //else if (horizontal < 0) horizontal += animConst;
            if (animator.GetFloat("Horizontal") > 0) animator.SetFloat("Horizontal", animator.GetFloat("Horizontal") - animConst);
            else if (animator.GetFloat("Horizontal") < 0) animator.SetFloat("Horizontal", animator.GetFloat("Horizontal") + animConst);
        }

        //Fight
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.SetTrigger("Punch");
        }

    }
}
