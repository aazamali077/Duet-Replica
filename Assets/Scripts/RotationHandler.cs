using UnityEngine;

public class RotationHandler : MonoBehaviour
{
     [SerializeField] float speed;
    //[SerializeField] TMPro.TextMeshProUGUI texts;
    void Update()
    {
         if (Input.touchCount>0)
         {
            Touch touch;
            touch = Input.GetTouch(0);
            if (touch.phase== TouchPhase.Began||touch.phase == TouchPhase.Moved||touch.phase == TouchPhase.Stationary)
            {
                Debug.Log(touch.position);

                if (touch.position.x<Screen.width/2)
                {
                    transform.rotation *= Quaternion.AngleAxis(speed * Time.deltaTime, Vector3.back);
                }
                else if(touch.position.x>Screen.width/2)
                {
                    transform.rotation *= Quaternion.AngleAxis(speed * Time.deltaTime, Vector3.forward);
                }
            }

         }

#if PLATFORM_WEBGL||UNITY_EDITOR_WIN

        if (Input.GetMouseButton(1)||Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(speed * Time.deltaTime * Vector3.back);
        }
        else if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(speed * Time.deltaTime * Vector3.forward);
        }
#endif
    }

}
