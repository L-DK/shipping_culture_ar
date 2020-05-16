using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FingerTouch : MonoBehaviour
{
    float distance = 30f;
    float xSpeed = 100f;
    float ySpeed = 100f;
    float x = 0f;
    float y = 0f;
    Vector2 oldPosition1;
    Vector2 oldPosition2;
    private bool flag_Roable = true;//自动旋转标志
    private AudioSource AudioSources;
    private System.DateTime oldTime;
    private System.DateTime nowTime;


    void Start()
    {

        Vector3 angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;

        oldTime = System.DateTime.Now;
    }

    void Update()
    {
        nowTime = System.DateTime.Now;
        System.TimeSpan ts1 = new System.TimeSpan(oldTime.Ticks);
        System.TimeSpan ts2 = new System.TimeSpan(nowTime.Ticks);

        System.TimeSpan ts = ts2.Subtract(ts1).Duration();
        if (ts.Seconds > 8 && !Input.anyKey)
        {
            flag_Roable = true;
            oldTime = System.DateTime.Now;
        }

        if (Input.touchCount >= 1)
        {
            variable.isRotate = false;

        }
        else if (Input.touchCount <= 0)
        {
            variable.isRotate = true;
        }

        if (Input.anyKey)
        {

           


            if (Input.touchCount == 1)
            {

                if (Input.GetTouch(0).phase == TouchPhase.Moved)
                {
                    x = Input.GetAxis("Mouse X") * xSpeed;
                    transform.Rotate(Vector3.up * -x * Time.deltaTime, Space.World);
                }

                if (Input.GetTouch(0).phase == TouchPhase.Moved)
                {
                    y = Input.GetAxis("Mouse Y") * ySpeed;
                    transform.Rotate(Vector3.right * +y * Time.deltaTime, Space.World);
                }
            }
            if (Input.touchCount > 1)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Moved && Input.GetTouch(1).phase == TouchPhase.Moved)
                {
                    Vector2 tempPosition1 = Input.GetTouch(0).position;
                    Vector2 tempPosition2 = Input.GetTouch(1).position;
                    if (isEnlarge(oldPosition1, oldPosition2, tempPosition1, tempPosition2))
                    {
                        float oldScale = transform.localScale.x;
                        float newScale = oldScale * 1.025f;
                        transform.localScale = new Vector3(newScale, newScale, newScale);
                    }
                    else
                    {
                        float oldScale = transform.localScale.x;
                        float newScale = oldScale / 1.025f;
                        transform.localScale = new Vector3(newScale, newScale, newScale);
                    }
                    //备份上一次触摸点的位置，用于对比   
                    oldPosition1 = tempPosition1;
                    oldPosition2 = tempPosition2;
                }
            }
        }
    }



    bool isEnlarge(Vector2 oP1, Vector2 oP2, Vector2 nP1, Vector2 nP2)
    {
        //函数传入上一次触摸两点的位置与本次触摸两点的位置计算出用户的手势   
        var leng1 = Mathf.Sqrt((oP1.x - oP2.x) * (oP1.x - oP2.x) + (oP1.y - oP2.y) * (oP1.y - oP2.y));
        var leng2 = Mathf.Sqrt((nP1.x - nP2.x) * (nP1.x - nP2.x) + (nP1.y - nP2.y) * (nP1.y - nP2.y));
        if (leng1 < leng2)
        {
            //放大手势   
            return true;
        }
        else
        {
            //缩小手势   
            return false;
        }
    }

}
