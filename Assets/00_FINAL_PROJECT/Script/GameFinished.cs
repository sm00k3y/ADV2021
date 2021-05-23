using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

[RequireComponent(typeof(Collider))]
public class GameFinished : MonoBehaviour
{
    public PlayableDirector finishTimeline;
    public KillCounter engine;
    // Start is called before the first frame update
    void Start()
    {
        finishTimeline.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (engine.GetKills() == 8)
        {
            finishTimeline.Play();
        }
    }
}
