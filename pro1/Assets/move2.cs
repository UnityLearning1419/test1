using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class move2 : MonoBehaviour
{
    // Start is called before the first frame update
    public WheelCollider TL;
    public WheelCollider TR;
    public WheelCollider BL;
    public WheelCollider BR;

    public Transform TTL;
    public Transform TTR;
    public Transform TBL;
    public Transform TBR;
    //是否可移动
    public bool Moveable;
    //速度
    float speed;
    //最大最小速度
    int maxspeed = 50;
    int minspeed = -20;
    //最大转弯速度
    int maxAngle = 60;
    //转弯速度
    float speedOfAngle;
    void Start()
    {
        Moveable = true;
        speed = 0;
        speedOfAngle = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.N))
        {
            Moveable = false;
        }
        if (Input.GetKey(KeyCode.Y))
        {
            Moveable = true;
        }
        //如果可以移动
        if (Moveable)
        {
            //Debug.Log(Input.GetAxis("move_r"));
            if (Input.GetKey(KeyCode.W) || Input.GetAxis("move_f") > 0)
            {
                if (speed < maxspeed)
                {
                    speed += Time.deltaTime * 10;
                }
            }
            else
            {
                if (speed > 0)
                {
                    speed -= Time.deltaTime * 3;
                }
            }
            //Debug.Log(transform.forward);

            if (Input.GetKey(KeyCode.S) || Input.GetAxis("move_f") < 0)
            {

                if (speed > minspeed)
                {
                    speed -= Time.deltaTime * 10;
                }
            }
            else
            {
                if (speed < 0)
                {
                    speed += Time.deltaTime * 3;
                }
               
            }
            //  Debug.Log(Input.GetAxis("hor"));
            if (Input.GetKey(KeyCode.D) || Input.GetKey("joystick button 5"))
            {
                //transform.Rotate(transform.up * 5 * speed * Time.deltaTime);
                if (speedOfAngle <maxAngle )
                {
                    speedOfAngle += Time.deltaTime * 50;
                }
            }
            else
            {
                if (speedOfAngle > 0)
                {
                    speedOfAngle -= Time.deltaTime * 30;
                }
            }
            if (Input.GetKey(KeyCode.A) || Input.GetKey("joystick button 4"))
            {
                //transform.Rotate(transform.up * -5 * speed * Time.deltaTime);
                if (speedOfAngle >-maxAngle)
                {
                    speedOfAngle -= Time.deltaTime * 50;
                }
            }
            else
            {
                if (speedOfAngle < 0)
                {
                    speedOfAngle += Time.deltaTime * 30;
                }
            }
            if (Input.GetKey(KeyCode.Space) || Input.GetKey("joystick button 1"))
            {
                BR.motorTorque = 0;
                BL.motorTorque = 0;
                TR.motorTorque = 0;
                TL.motorTorque = 0;

                TR.brakeTorque += 10000 * Time.deltaTime;
                BL.brakeTorque += 10000 * Time.deltaTime;
                BR.brakeTorque += 10000 * Time.deltaTime;
                TL.brakeTorque += 10000 * Time.deltaTime;

                if (speed > 0)
                {
                    speed -= Time.deltaTime * 50;
                }
                if (speed < 0.1)
                {
                    speed = 0;
                }

            }
            else
            {
                TR.brakeTorque = 0;
                BL.brakeTorque = 0;
                BR.brakeTorque = 0;
                TL.brakeTorque = 0;
            }

        }
        BR.motorTorque= speed * 1000 ;
        BL.motorTorque = BR.motorTorque;
        TR.motorTorque = speed * 1000;
        TL.motorTorque = BR.motorTorque;

        TR.steerAngle = speedOfAngle;
        TL.steerAngle = TR.steerAngle;

        updateWheel(TBL, BL);
        updateWheel(TTL, TL);
        updateWheel(TTR, TR);
        updateWheel(TBR, BR);

    }

    void updateWheel(Transform wheel,WheelCollider col)
    {
        Vector3 pos = wheel.position;
        Quaternion rot = wheel.rotation;

        col.GetWorldPose(out pos, out rot);

        wheel.position = pos;
        wheel.rotation = rot;
    }
}
