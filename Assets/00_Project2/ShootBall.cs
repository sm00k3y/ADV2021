using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ShootBall : MonoBehaviour
{
    Rigidbody ball;

    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            ball.AddForce(transform.right * 1000f);
        }
    }
}
