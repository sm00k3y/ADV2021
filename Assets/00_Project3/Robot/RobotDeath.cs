using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotDeath : MonoBehaviour
{
    public Animator animator;
    public GameObject explosionEffect;
    public Animator skulls;
    public AudioSource explosionAudio;
    private bool dead = false;

    public void OnTriggerEnter(Collider other)
    {
        animator.SetBool("Dead", true);
        if(!dead)
        {
            //Debug.Log(transform.position[0]);
            Instantiate(explosionEffect, new Vector3(transform.position[0], transform.position[1] + 1, transform.position[2]), transform.rotation);
            dead = true;
            skulls.SetFloat("Kills", skulls.GetFloat("Kills") + 0.125f);
            explosionAudio.Play();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("Dead", false);
            skulls.SetFloat("Kills", 0f);
            dead = false;
        }
    }
}
