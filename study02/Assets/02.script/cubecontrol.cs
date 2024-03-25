using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//큐브를 회전시키고 싶다.
public class cubecontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Transform>().Rotate(1, 0.5f, 1);
        // transform == GetComponent<Transform>()
        // transform.Rotate(1, 0.5f, 1);
    }
}
