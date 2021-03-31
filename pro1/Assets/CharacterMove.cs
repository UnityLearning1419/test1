using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    // Start is called before the first frame update
    //是否可移动
    public bool Moveable;
    //速度
    float speed;
    //最大最小速度
    int maxspeed = 50;
    int minspeed = -20;
    //最大转弯速度
    int maxAngle = 20;
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
        //如果n则不可控制移动
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
            if (Input.GetKey(KeyCode.W) || Input.GetAxis("move_f") >0)
            {
                if (speed < maxspeed)
                {
                    speed += Time.deltaTime*10;
                }
                if (speedOfAngle < maxAngle)
                {
                    speedOfAngle += Time.deltaTime * 10;
                }
            }
            else
            {
                if (speed > 0)
                {
                    speed -= Time.deltaTime*3;
                }
                if (speedOfAngle > 0)
                {
                    speedOfAngle += Time.deltaTime * 10;
                }
            }
            //Debug.Log(transform.forward);
           
            if (Input.GetKey(KeyCode.S) || Input.GetAxis("move_f") < 0)
            {
                if (speed > minspeed)
                {
                    speed -= Time.deltaTime * 10;
                }
                if (speedOfAngle < maxAngle)
                {
                    speedOfAngle += Time.deltaTime * 10;
                }
            }
            else
            {
                if (speed < 0)
                {
                    speed += Time.deltaTime * 3;
                }
                if (speedOfAngle > 0)
                {
                    speedOfAngle += Time.deltaTime * 10;
                }
            }
          //  Debug.Log(Input.GetAxis("hor"));
            if (Input.GetKey(KeyCode.D) || Input.GetKey("joystick button 5") )
            {
                transform.Rotate(transform.up * 5*speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A)||Input.GetKey("joystick button 4"))
            {
                transform.Rotate(transform.up * -5*speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.Space)||Input.GetKey("joystick button 1"))
            {
                if (speed > 0)
                {
                    speed -= Time.deltaTime * 50;
                }
                if (speed < 0)
                {
                    speed = 0;
                }
                
            }
            
        }
        transform.position += transform.forward * speed * Time.deltaTime;

    }
 }
