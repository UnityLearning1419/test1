using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ThirdView;
    public GameObject FirstView;
    public GameObject realCar;
    public GameObject CameraFather;
    public float mouseSensitivity;
    float mouseX, mouseY;
    float yAngle;

    PlayerControls controls;
    //获取输入设备的x，y位移差值，[-1,1]
    Vector2 cameraRotate;
    //第一称为1第三人称为3
    int viewType;
    void Start()
    {
        controls = new PlayerControls();
        controls.Enable();
        viewType = 3;
        controls.player.switchView.performed +=info=> viewSwitch();
    }

    // Update is called once per frame
    void Update()
    {
        //获取输入设备的xy位移差[-1,1]
        cameraRotate = controls.player.camera.ReadValue<Vector2>();
        mouseX = cameraRotate.x * mouseSensitivity * Time.deltaTime;
        mouseY = cameraRotate.y * mouseSensitivity * Time.deltaTime;
        switch (viewType) {
            case 1:First(); break;
            case 3:Third(); break;
        }
    }
    void viewSwitch()
    {
        if (viewType == 1)
        {
            viewType = 3;
        }
        else
        {
            viewType = 1;
            //transform.eulerAngles = Vector3.zero;
        }
    }
    void First()
    {
        //第一人称调整fov为人眼
        Camera mainCamera = GetComponent<Camera>();
        mainCamera.fieldOfView = 72;
       
        //移动摄像机到第一人称位置
        CameraFather.transform.position=FirstView.transform.position;
        //移动鼠标转动视角
        CameraFather.transform.Rotate(Vector3.up*mouseX);
        Debug.Log(mouseX);
        yAngle += mouseY;
        transform.localRotation = Quaternion.Euler(yAngle, 0, 0);
      
    }
    void Third()
    {
        //第三人称应该fov较大
        Camera mainCamera = GetComponent<Camera>();
        mainCamera.fieldOfView = 90;
        //移动到第三人称摄像位置
        CameraFather.transform.position =ThirdView.transform.position;
        //看向汽车
        transform.LookAt(realCar.transform);
    }
}
