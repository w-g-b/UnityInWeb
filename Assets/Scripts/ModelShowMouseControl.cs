using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelShowMouseControl : MonoBehaviour
{
    //目标物体  
    private int MouseWheelSensitivity = 10; //放大倍数的快慢  
    private int MouseZoomMin = 1; //最小倍数  

    private int MouseZoomMax = 5; //最大倍数  

    private Vector3 normalized;

    //拖拽的移动速度  
    private float xSpeed = 250.0f;
    private float ySpeed = 120.0f;

    //拖拽的高度限制  
    private int yMinLimit = -20;
    private int yMaxLimit = 80;

    //角度  
    private float x = 0.0f;
    private float y = 0.0f;

    //记录目标物体的坐标  
    private Vector3 screenPoint;
    private Vector3 offset;

    //目标的3D坐标  
    private Vector3 CameraTarget;


    void Start()
    {
    }

    void Update()
    {
        //如果左击了，旋转  
        if (Input.GetMouseButton(0))
        {
            x += -Input.GetAxis("Mouse X") * xSpeed * 0.02f;
            y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;

            var rotation = Quaternion.Euler(y, x, 0);

            transform.rotation = rotation;
        }
        //滚轮缩放  
        else if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            var scaleValue = -Input.GetAxis("Mouse ScrollWheel") * MouseWheelSensitivity;
            print(scaleValue);
            transform.localScale = new Vector3(transform.localScale.x - scaleValue, transform.localScale.y - scaleValue,
                transform.localScale.z - scaleValue);
        }
    }
    
}