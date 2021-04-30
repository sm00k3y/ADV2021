using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentController : MonoBehaviour
{
    public Transform goal;
    UnityEngine.AI.NavMeshAgent agent;
    Animator animatorNinja;
    public Transform destinyMark;
    public Camera camera;
    private bool isJumping = false;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        animatorNinja = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out RaycastHit hit))
            {
                agent.destination = destinyMark.position = hit.point;
                destinyMark.GetComponent<AudioSource>().Play();
            }
        }

        if (agent.isOnOffMeshLink && !isJumping)
        {
            animatorNinja.SetTrigger("JumpTrigger");
            isJumping = true;
        }
        else if (!agent.isOnOffMeshLink)
        {
            if (isJumping) { isJumping = false; }
        }

        animatorNinja.SetFloat("Horizontal", transform.InverseTransformDirection(agent.velocity).x);
        animatorNinja.SetFloat("Vertical", transform.InverseTransformDirection(agent.velocity).z);
    }
}
