using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public string names;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == names)
        {
            Destroy(collision.gameObject);
        }
    }

}
