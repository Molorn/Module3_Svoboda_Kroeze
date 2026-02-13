using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
public class Breakable : MonoBehaviour
{

    [SerializeField] GameObject fullPot;
    [SerializeField] GameObject brokenPot;

    public GameObject paperSlip;

    private AudioSource shatter;

    BoxCollider bc;
    // Start is called before the first frame update

    private void Start()
    {
        shatter = GetComponent<AudioSource>();
    }
    private void Awake()
    {
        fullPot.SetActive(true);
        brokenPot.SetActive(false);
        if (paperSlip != null)
        {
            paperSlip.SetActive(false);
        }

        bc = GetComponent<BoxCollider>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Break();
        }
    }

    private void Break()
    {
        fullPot.SetActive(false);
        brokenPot.SetActive(true);
        transform.DetachChildren();
        if (paperSlip != null)
        {
            paperSlip.SetActive(true);
        }
        if (!shatter.isPlaying)
        {
            shatter.Play();
        }
    }
}
