using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class ControlAnimaciones : MonoBehaviour
{
    public Animator animator;
    public string parameterBoolean;
    bool b = false;

    private void OnTriggerEnter(Collider other)
    {
        b = !b;
        animator.SetBool(parameterBoolean, b);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
