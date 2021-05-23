using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class AlienDead : MonoBehaviour
{
    public Animator animator;
    public GameObject player;
    public KillCounter killCounter;
    public AudioSource hitSound;
    private int health = 2;
    private bool isDead = false;
    private void OnTriggerEnter(Collider other)
    {
        health--;
        hitSound.Play();
        if (health == 0)
        {
            isDead = true;
            animator.SetTrigger("Dead");
            killCounter.UpdateKillCount();
        }
        else animator.SetTrigger("Hit");
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!isDead)
        {
            Vector3 playerPos = player.transform.position;
            Vector3 npcPos = gameObject.transform.position;
            Vector3 delta = new Vector3(playerPos.x - npcPos.x, 0.0f, playerPos.z - npcPos.z);
            Quaternion rotation = Quaternion.LookRotation(delta);
            gameObject.transform.rotation = rotation;
        }
    }
}
