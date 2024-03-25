using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //게임매니저가 게임의 요소를 통제하려면
    //게임매니저가 게임의 모든 요소를 속성(멤버변수)로 들고 있으면 된다.

    //프리팹(클래스)들
    GameObject playerPrefab;
    GameObject aninalPrefab;
    GameObject boxPrefab;

    //게임 안에서 사용할 전체 오브젝트들
    GameObject player;
    GameObject[] animals;
    GameObject[] boxes;

    //게임 안에서 사용할 전체 UI 오브젝트들



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
