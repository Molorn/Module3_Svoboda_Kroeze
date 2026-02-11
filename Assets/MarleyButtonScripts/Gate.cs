using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public GameObject otherObject;
    public bool gateOpen;
    //public Transform targetPosition;
    //public float speed = 5f;

    public void OpenGate()
    {
        gateOpen = true;
        Debug.Log("Gate opened by opengate function");
        Destroy(otherObject);
    }

    void Start()
    {
        //targetPosition = Vector3(-0.3f, -1f, -4.5f);
        //gateOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gateOpen == true)
        {
            Debug.Log("Gate opened by update function");
            Destroy(gameObject);
            //transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, speed * Time.deltaTime);
        }
    }

    void OnDestroy()
    {
        Debug.Log("Gate destroyed");
    }
}
