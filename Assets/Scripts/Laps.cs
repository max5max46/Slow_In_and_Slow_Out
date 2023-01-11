using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Playables;

public class Laps : MonoBehaviour
{
    public PlayableDirector timeline;
    public TextMeshPro lapsText;
    private bool timelineStarted = false;
    private float time = 1;
    private float lapTime = 0;
    private int lapCount = -1;


    void Update()
    {
        time += Time.deltaTime;

        if (Input.GetKey("e") && timelineStarted == false)
        {
            timeline.Play();
            timelineStarted = true;
        }

        if (timelineStarted == true)
        {
            if (lapTime <= time)
            {
                Debug.Log("Hit");
                lapTime = time + 7;
                lapCount++;
                lapsText.text = "Laps: " + lapCount;
            }
        }
    }
}
