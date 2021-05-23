/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    public float DownAccel = 1;
    public float animConst = 1f;
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
        charController.Move(Vector3.down * DownAccel * Time.deltaTime);
        //animator.SetFloat("Horizontal", 0);
        //animator.SetFloat("Vertical", 0);

        // Vertical movement
        if (Input.GetKey(KeyCode.I))
        {
            //if (animator.GetFloat("Vertical") < 1.0f) animator.SetFloat("Vertical", animator.GetFloat("Vertical") + animConst);
            if (vertical < 1.0f) vertical += animConst;
        }
        else if (Input.GetKey(KeyCode.K))
        {
            //if (animator.GetFloat("Vertical") > -1.0f) animator.SetFloat("Vertical", animator.GetFloat("Vertical") - animConst);
            if (vertical > -1.0f) vertical -= animConst;
        }
        else
        {
            //if (animator.GetFloat("Vertical") > 0) animator.SetFloat("Vertical", animator.GetFloat("Vertical") - animConst);
            //else if (animator.GetFloat("Vertical") < 0) animator.SetFloat("Vertical", animator.GetFloat("Vertical") + animConst);
            if (vertical > 0) vertical -= animConst;
            else if (vertical < 0) vertical += animConst;
        }

        //Horizontal movement
        if (Input.GetKey(KeyCode.J))
        {
            //if (animator.GetFloat("Horizontal") > -1.0f) animator.SetFloat("Horizontal", animator.GetFloat("Horizontal") - animConst);
            if (horizontal > -1.0f) horizontal -= animConst;
        }
        else if (Input.GetKey(KeyCode.L))
        {
            if (horizontal < 1.0f) horizontal += animConst;
            //if (animator.GetFloat("Horizontal") < 1.0f) animator.SetFloat("Horizontal", animator.GetFloat("Horizontal") + animConst);
        }
        else
        {
            if (horizontal > 0) horizontal -= animConst;
            else if (horizontal < 0) horizontal += animConst;
            //if (animator.GetFloat("Horizontal") > 0) animator.SetFloat("Horizontal", animator.GetFloat("Horizontal") - animConst);
            //else if (animator.GetFloat("Horizontal") < 0) animator.SetFloat("Horizontal", animator.GetFloat("Horizontal") + animConst);
        }

        var movement = new Vector3(horizontal, 0, vertical);
        charController.Move(movement * Time.deltaTime * moveSpeed);
        animator.SetFloat("Speed", movement.magnitude);

        if (movement.magnitude > 0)
        {
            Quaternion newDir = Quaternion.LookRotation(movement);
            transform.rotation = Quaternion.Slerp(transform.rotation, newDir, Time.deltaTime * turnSpeed);
        }

    }
}
*/