using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontrol : MonoBehaviour
{
    GameObject myCube;
    //아웃렛 소켓
    public GameObject otherCube;
    // Start is called before the first frame update
    public GameObject sphere;
    int cnt = 0;  
    void Start()
    {
        myCube = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject.Find("Cube").transform.Rotate(1, 0.5f, 1);
        //GameObject.Find("오브젝트이름")
        if (Input.GetMouseButtonDown(0))
        {
            cnt = cnt + 1;
            if (cnt > 3)
            {
                cnt = 0;
            }
        }

        /*switch ( value )
        {
            case 1:
                break;
            case 2:
                break; 
        }
        */

        if (cnt == 1)
        {
            myCube.transform.Rotate(1,0.5f,1);
        }
        else if (cnt == 2) 
        {
            otherCube.transform.Rotate(1,0.5f,1) ;

        }
        else if (cnt == 3) 
        {
            sphere.transform.Translate(0.5f, 0.5f, 0.5f);
        }
        //Translate(x,y,z)
            
    }
}
