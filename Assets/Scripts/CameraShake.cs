using UnityEngine;

public class CameraShake : MonoBehaviour
{ private float shakeDuration = 0.1f;
    private float shakeMagnitude = 0.1f;
    private float shakeDecreaseFactor = 1.0f;

    private Vector3 originalPos;
    private bool isShaking = false;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.name == "box")
        {
            originalPos = Camera.main.transform.position;
            isShaking = true;
        }
        
    }

    void Update()
    {
        if (isShaking)
        {
            if (shakeDuration > 0)
            {
                Camera.main.transform.position = originalPos + Random.insideUnitSphere * shakeMagnitude;

                shakeDuration -= Time.deltaTime * shakeDecreaseFactor;
            }
            else
            {
                isShaking = false;
                shakeDuration = 0.07f;
                Camera.main.transform.position = originalPos;
            }
        }
    }
}

