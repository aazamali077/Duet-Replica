using UnityEngine;

public class RotationHandler : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] TMPro.TextMeshProUGUI texts;
    void Update()
    {
         if (Input.touchCount>0)
         {
            Touch touch;
            touch = Input.GetTouch(0);
            if (touch.phase== TouchPhase.Began)
            {
                Debug.Log(touch.position);
                //texts.text = touch.position.ToString();

                if (touch.position.x<Screen.width/2)
                {
                    transform.Rotate(speed * Time.deltaTime * Vector3.back);
                    //transform.eulerAngles += Vector3.forward*speed * Time.deltaTime;
                    texts.text = "Left Touch";
                }
                else if(touch.position.x>Screen.width/2)
                {
                    transform.Rotate(speed * Time.deltaTime * Vector3.forward);
                    //transform.eulerAngles -= Vector3.forward*speed * Time.deltaTime;
                    texts.text = "Right Touch";
                }
            }

         }


          if (Input.GetMouseButton(1))
            {
                transform.Rotate(speed * Time.deltaTime * Vector3.back);
                //transform.eulerAngles -= Vector3.forward*speed * Time.deltaTime;
                //transform.Rotate(Vector3.forward, -speed* Time.deltaTime);
            }
           if (Input.GetMouseButton(0))
            {
                transform.Rotate(speed * Time.deltaTime * Vector3.forward);
                //transform.eulerAngles += Vector3.forward*speed * Time.deltaTime;
                //transform.Rotate(Vector3.forward, -speed * Time.deltaTime); 
        }
                
    }
    
}
