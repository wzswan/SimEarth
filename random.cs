using UnityEngine;
using System.Collections;

public class random : MonoBehaviour {
    float stopTime;
    float moveTime;
   float vel_x, vel_y, vel_z;//速度
                              ///
                              /// 最大、最小飞行界限
                              ///
    float maxPos_x = -90;
    float maxPos_y = 200;
    float maxPos_z = 500;
    float minPos_x = -520;
    float minPos_y = 10;
    float minPos_z = 0;
    int curr_frame;
    int total_frame;
    float timeCounter1;
    float timeCounter2;

    private Vector3 tempPosition;


    // Use this for initialization
    void Start () {
     //   tempPosition = transform.localPosition;
        Change();
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter1 += Time.deltaTime;
        if (timeCounter1 < moveTime)
        {
            transform.Translate(vel_x, vel_y, vel_z, Space.Self);
        }
        else
        {
            timeCounter2 += Time.deltaTime;
            if (timeCounter2 > stopTime)
            {
                Change();
                timeCounter1 = 0;
                timeCounter2 = 0;
            }
        }
        Check();
    }
    void Change()
    {
        stopTime = Random.Range(1, 5);
        moveTime = Random.Range(1, 20);
        vel_x = Random.Range(-3, 3)/1000;
        vel_y = Random.Range(-3, 3)/1000;
        vel_z = Random.Range(-3, 3)/1000;
    }
    void Check()
    {
        //如果到达预设的界限位置值，调换速度方向并让它当前的坐标位置等于这个临界边的位置值
        if (transform.localPosition.x > maxPos_x)
        {
            vel_x = -vel_x;
            transform.localPosition = new Vector3(maxPos_x, transform.localPosition.y, 0);
        }
        if (transform.localPosition.x < minPos_x)
        {
            vel_x = -vel_x;
            transform.localPosition = new Vector3(minPos_x, transform.localPosition.y, 0);
        }
        if (transform.localPosition.y > maxPos_y)
        {
            vel_y = -vel_y;
            transform.localPosition = new Vector3(transform.localPosition.x, maxPos_y, 0);
        }
        if (transform.localPosition.y < minPos_y)
        {
            vel_y = -vel_y;
            transform.localPosition = new Vector3(transform.localPosition.x, minPos_y, 0);
        }
        if (transform.localPosition.z > maxPos_z)
        {
            vel_z = -vel_z;
            transform.localPosition = new Vector3(transform.localPosition.x, maxPos_z, 0);
        }
        if (transform.localPosition.y < minPos_y)
        {
            vel_z = -vel_z;
            transform.localPosition = new Vector3(transform.localPosition.x, minPos_z, 0);
        }
    }
}

