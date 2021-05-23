using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class KillCounter : MonoBehaviour
{
    public Animator door1;
    public Animator door2;
    public Animator door3;
    public Text myText;
    private int killCount = 0;
    private bool door_1_opened = false;
    private bool door_2_opened = false;
    private bool door_3_opened = false;
    public PlayableDirector finishTimeline;
    // Start is called before the first frame update
    void Start()
    {
        finishTimeline.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        myText.text = "Kill Count: " + killCount;
        if (killCount == 4 && !door_1_opened)
        {
            door1.SetTrigger("OpenDoor");
            door_1_opened = true;
        }

        if (killCount == 6 && !door_2_opened)
        {
            door2.SetTrigger("OpenDoor");
            door_2_opened = true;
        }

        if (killCount == 8 && !door_3_opened)
        {
            door3.SetTrigger("OpenDoor");
            door_3_opened = true;
            StartCoroutine(waiter());
            //finishTimeline.Play();
        }
    }

    public void UpdateKillCount()
    {
        killCount++;
    }

    public int GetKills()
    {
        return killCount;
    }

    IEnumerator waiter()
    {
        //Wait for 4 seconds
        yield return new WaitForSeconds(2);

        finishTimeline.Play();
    }
}
