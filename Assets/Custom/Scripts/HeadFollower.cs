using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadFollower : MonoBehaviour
{

    public Transform Head;


    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
               Head.position.x + 0.2f,
               Head.position.y - 0.3f,
               Head.position.z + 0.2f
           );
        transform.rotation = Quaternion.Euler(90f, 45f, 180f);
    }
}
