using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedController : MonoBehaviour
{
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(changespeed());
    }
    void Update()
    {
        if (rb.velocity.y < GameManager.maxSpeed) rb.velocity = new Vector2(rb.velocity.x, GameManager.maxSpeed);
    }


    IEnumerator changespeed()
    {
        yield return new WaitForSeconds(10);
        GameManager.maxSpeed *=  1.2f;
        StartCoroutine(changespeed());
    }
}
