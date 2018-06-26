using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : MonoBehaviour
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

    //围绕x旋转30°  
    private Quaternion rotation = Quaternion.Euler(new Vector3(30f, 0f, 0f));

    //目标的3D坐标  
    private Vector3 CameraTarget;

    //打印欧拉角:绕各个轴旋转的角度，顺时针为正方向  
    public void Awake()
    {
        print(transform.eulerAngles.x);
        print(transform.eulerAngles.y);
        print(transform.eulerAngles.z);
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
        //案件按下 记录鼠标的  
        else if (Input.GetMouseButtonDown(2))
        {
            //将目标物体的坐标转化成平面坐标  
            screenPoint = Camera.main.WorldToScreenPoint(transform.position);
            //计算鼠标的3维坐标跟物体的3维坐标的差值  
            offset = transform.position -
                     Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,
                         screenPoint.z));
        }

        //中键拖拽，改变飞机的坐标，每帧调用  
        if (Input.GetMouseButton(2))
        {
            //鼠标的平面坐标  
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            //鼠标转移的3d空间坐标值  
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            //改变鼠标的3D空间坐标  
            transform.position = curPosition;
        }

        //朝向，每动一帧都要改变朝向  
//        transform.LookAt(CameraTarget);
    }

    //控制旋转的角度，如果旋转的角度大于360或者小于360都要加上或者减去对应的角度  
    static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360)
            angle += 360;
        if (angle > 360)
            angle -= 360;
        return Mathf.Clamp(angle, min, max);
    }
}