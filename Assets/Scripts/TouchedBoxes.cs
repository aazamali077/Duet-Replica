using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchedBoxes : MonoBehaviour
{
    public bool istouched = false;
    [SerializeField] ParticleSystem burst;
    [SerializeField] GameObject GameOver;



    void Update()
    {
        if (istouched)
        {
            GameManager.isgameover = true;
            Time.timeScale -= .1f*Time.deltaTime;
            Debug.Log(Time.timeScale);
            if (Time.timeScale <= 0.15f)
            {
                Time.timeScale = 0f;
                istouched = false;
                GameOver.SetActive(true);
            }
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "box")
        {
            Time.timeScale = 0.2f;
            burst.Play();
            //this.gameObject.SetActive(false);
            this.GetComponent<SpriteRenderer>().enabled = false;
            this.GetComponent<TrailRenderer>().enabled = false;
            this.GetComponentInParent<RotationHandler>().enabled = false;
            GetComponent<CircleCollider2D>().enabled = false;
            istouched = true;
        }
    }


}
