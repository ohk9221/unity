using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidcontrol : MonoBehaviour
{
    Rigidbody body;
    /* Rigidbody�� �ֿ� �Ӽ�
     1) velocity : �̵� �ӵ�
     2) angularvelocity : ȸ�� �ӵ�
    Rigidbody�� �ֿ� �޼���
    1) MovePosition : Ư�� ��ǥ�� �̵���Ŵ
    2) MoveRotation : Ư�� ������ ȸ����Ŵ
    3) **** Addforce : Ư�� �������� ���� ����
    4) AddTorque : Ư�� �������� ȸ������ ����
    */
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        //gameObject = ��ũ��Ʈ�� ���� �ڱ� �ڽ� ������Ʈ
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
