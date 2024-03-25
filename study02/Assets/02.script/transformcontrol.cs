using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformcontrol : MonoBehaviour
{
    /* Transform
     �ֿ� �������(�ʵ�)
        - position : ��ġ position.x, position.y, position.z
        - rotation : ����
        - scale : ����
        forward, right, up
    �ֿ� �޼���
        Translate(Vector3)
        Rotate
    */

    public GameObject player; //���ӿ�����Ʈ ��ü
    public Transform playerT; //���ӿ�����Ʈ�� Transform������Ʈ�� �����ϴ� ����
    public Transform CubeT;
    float pX, pY, pZ;
    float rX, rY, rZ;
    // Start is called before the first frame update
    void Start()
    {
        print(playerT.position.x);
        print(playerT.position.y);
        print(playerT.position.z);
        //playerT.position = new Vector3(5,0,0); //Transform�� position�� �̿��� ��ġ ����
        pX = playerT.position.x;
        pY = playerT.position.y;
        pZ = playerT.position.z;
        rX = playerT.rotation.x;
        rY = playerT.rotation.y;
        rZ = playerT.rotation.z;
        print(playerT.Find("Main Camera").position.x);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) //������ Ű�� �ڵ带 �޴´�.

        {
            //pX += -0.01f; // pX = pX + 0.01f;
            //playerT.position = new Vector3(++pX, pY, pZ);
            playerT.position += playerT.right * 0.01f; //���������� 1����
        }

        if (Input.GetKey(KeyCode.LeftArrow)) //���� Ű�� �ڵ带 �޴´�.

        {
            //pX += -0.01f; // pX = pX + 0.01f;
            //playerT.position = new Vector3(++pX, pY, pZ);
            playerT.position += playerT.right * -0.01f; //�������� 1����
        }
        
        if (Input.GetKey(KeyCode.UpArrow)) //���� Ű�� �ڵ带 �޴´�.

        {
            //pX += -0.01f; // pX = pX + 0.01f;
            //playerT.position = new Vector3(++pX, pY, pZ);
            playerT.position += playerT.forward * 0.01f; //�������� 1����
        }
        
        if (Input.GetKey(KeyCode.DownArrow)) //���� Ű�� �ڵ带 �޴´�.

        {
            //pX += -0.01f; // pX = pX + 0.01f;
            //playerT.position = new Vector3(++pX, pY, pZ);
            playerT.position += playerT.forward * -0.01f; //�������� 1����
        }


        if (Input.GetKey(KeyCode.A)) //AŰ�� ������ �������� ȸ��
        {
            //playerT.rotation = Quaternion.Euler(rX, --rY, rZ);
            playerT.eulerAngles = new Vector3 ( rX, --rY, rZ);
        }
        if (Input.GetKey(KeyCode.W)) //AŰ�� ������ �������� ȸ��
        {
            //playerT.rotation = Quaternion.Euler(rX, --rY, rZ);
            playerT.eulerAngles = new Vector3(--rX, rY, rZ);
        }
        if (Input.GetKey(KeyCode.D)) //AŰ�� ������ �������� ȸ��
        {
            //playerT.rotation = Quaternion.Euler(rX, --rY, rZ);
            playerT.eulerAngles = new Vector3(rX, ++rY, rZ);
        }
        if (Input.GetKey(KeyCode.S)) //AŰ�� ������ �������� ȸ��
        {
            //playerT.rotation = Quaternion.Euler(rX, --rY, rZ);
            playerT.eulerAngles = new Vector3(++rX, rY, rZ);
        }

        //�ڽ� ������Ʈ�� �����ϴ¹�
        // 1) ��ȣ�� ���� playerT.GetChild(0) -> �÷��̾��� ù��° �ڽ�
        // playerT.GetChild(2) or Player.transform.GetChild(2)

        // 2) playerT.Find("Main Camera")
        if ((Input.GetKey(KeyCode.Space)))
        {
            playerT.LookAt(CubeT.position);
        }
    }
}
