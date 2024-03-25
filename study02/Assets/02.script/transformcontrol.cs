using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformcontrol : MonoBehaviour
{
    /* Transform
     주요 멤버변수(필드)
        - position : 위치 position.x, position.y, position.z
        - rotation : 각도
        - scale : 배율
        forward, right, up
    주요 메서드
        Translate(Vector3)
        Rotate
    */

    public GameObject player; //게임오브젝트 객체
    public Transform playerT; //게임오브젝트의 Transform컴포넌트를 연결하는 변수
    public Transform CubeT;
    float pX, pY, pZ;
    float rX, rY, rZ;
    // Start is called before the first frame update
    void Start()
    {
        print(playerT.position.x);
        print(playerT.position.y);
        print(playerT.position.z);
        //playerT.position = new Vector3(5,0,0); //Transform의 position을 이용해 위치 변경
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
        if (Input.GetKey(KeyCode.RightArrow)) //오른쪽 키의 코드를 받는다.

        {
            //pX += -0.01f; // pX = pX + 0.01f;
            //playerT.position = new Vector3(++pX, pY, pZ);
            playerT.position += playerT.right * 0.01f; //오른쪽으로 1미터
        }

        if (Input.GetKey(KeyCode.LeftArrow)) //왼쪽 키의 코드를 받는다.

        {
            //pX += -0.01f; // pX = pX + 0.01f;
            //playerT.position = new Vector3(++pX, pY, pZ);
            playerT.position += playerT.right * -0.01f; //왼쪽으로 1미터
        }
        
        if (Input.GetKey(KeyCode.UpArrow)) //왼쪽 키의 코드를 받는다.

        {
            //pX += -0.01f; // pX = pX + 0.01f;
            //playerT.position = new Vector3(++pX, pY, pZ);
            playerT.position += playerT.forward * 0.01f; //왼쪽으로 1미터
        }
        
        if (Input.GetKey(KeyCode.DownArrow)) //왼쪽 키의 코드를 받는다.

        {
            //pX += -0.01f; // pX = pX + 0.01f;
            //playerT.position = new Vector3(++pX, pY, pZ);
            playerT.position += playerT.forward * -0.01f; //왼쪽으로 1미터
        }


        if (Input.GetKey(KeyCode.A)) //A키를 누르면 왼쪽으로 회전
        {
            //playerT.rotation = Quaternion.Euler(rX, --rY, rZ);
            playerT.eulerAngles = new Vector3 ( rX, --rY, rZ);
        }
        if (Input.GetKey(KeyCode.W)) //A키를 누르면 왼쪽으로 회전
        {
            //playerT.rotation = Quaternion.Euler(rX, --rY, rZ);
            playerT.eulerAngles = new Vector3(--rX, rY, rZ);
        }
        if (Input.GetKey(KeyCode.D)) //A키를 누르면 왼쪽으로 회전
        {
            //playerT.rotation = Quaternion.Euler(rX, --rY, rZ);
            playerT.eulerAngles = new Vector3(rX, ++rY, rZ);
        }
        if (Input.GetKey(KeyCode.S)) //A키를 누르면 왼쪽으로 회전
        {
            //playerT.rotation = Quaternion.Euler(rX, --rY, rZ);
            playerT.eulerAngles = new Vector3(++rX, rY, rZ);
        }

        //자식 오브젝트에 접근하는법
        // 1) 번호로 접근 playerT.GetChild(0) -> 플레이어의 첫번째 자식
        // playerT.GetChild(2) or Player.transform.GetChild(2)

        // 2) playerT.Find("Main Camera")
        if ((Input.GetKey(KeyCode.Space)))
        {
            playerT.LookAt(CubeT.position);
        }
    }
}
