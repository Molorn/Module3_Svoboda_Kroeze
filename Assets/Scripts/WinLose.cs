using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinLose : MonoBehaviour
{
    public GameObject winTextObject;
    private Transform playerTransform;

    void Start()
    {
        winTextObject.SetActive(false);
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
    }

    void Update()
    {
        //if (playerTransform.position.x <= -55)
        //{
            //winTextObject.SetActive(true);
        //}
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            winTextObject.gameObject.SetActive(true);
            winTextObject.GetComponent<TextMeshProUGUI>().text = "You Lose!";
        }
    }

}
