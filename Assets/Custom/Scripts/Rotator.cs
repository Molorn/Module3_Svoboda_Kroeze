using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Rotator : MonoBehaviour
{

    float timeVar = 0.5f;
    bool floatUp = false;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 40, 0) * Time.deltaTime);

        timeVar += Time.deltaTime;
        if (timeVar >= 1f)
        {
            floatUp = !floatUp;
            timeVar = 0f;
        }

        if (floatUp)
        {
            transform.Translate(Vector3.up * 1.0f * Time.deltaTime);
        }
        if (!floatUp)
        {
            transform.Translate(Vector3.down * 1.0f * Time.deltaTime);
        }
    }
}