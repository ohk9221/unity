using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roulette : MonoBehaviour
{
    float rotSpeed = 0; // 회전 속도
    // Start is called before the first frame update
    void Start()
    {
        //프레임레이트를 60으로 고정한다.
        Application.targetFrameRate = 60;
    }
    // Update is called once per frame
    void Update()
    {
     //클릭하면 회전 속도를 설정한다.
     if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 100;
        }

     //회전 속도만큼 룰렛을 회전시킨다.
     transform.Rotate(0,0,this.rotSpeed);

        this.rotSpeed *= 0.96f;
    }
}
