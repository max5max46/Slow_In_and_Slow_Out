using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sus : MonoBehaviour
{
    private float time = 9999999;


    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
    }
}
