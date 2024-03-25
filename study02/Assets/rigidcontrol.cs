using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidcontrol : MonoBehaviour
{
    Rigidbody body;
    /* Rigidbody의 주요 속성
     1) velocity : 이동 속도
     2) angularvelocity : 회전 속도
    Rigidbody의 주요 메서드
    1) MovePosition : 특정 좌표로 이동시킴
    2) MoveRotation : 특정 각도로 회전시킴
    3) **** Addforce : 특정 방향으로 힘을 가함
    4) AddTorque : 특정 방향으로 회전력을 가함
    */
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        //gameObject = 스크립트가 속한 자기 자신 오브젝트
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            //body.AddForce(Vector3.left);
            body.AddForce(new Vector3(-1,0,0));
            //body.angularVelocity = Vector3.down;
        }
        else
        {
            //body.angularVelocity = new Vector3(0,0,0);
        }
    }
}
