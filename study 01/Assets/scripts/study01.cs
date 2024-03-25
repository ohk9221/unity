using System.Collections;
// using : System.Collections라는 이름의 네임스페이스를 사용하겠다.
// 네임스페이스 : 쉽게 '코드의 폴더'이다.
using System.Collections.Generic;
using UnityEngine;
// using으로 추가해 놓고 사용하고 있는 건 검은색, 사용하지 않고 있는 것은 회색으로 표시됨
public class Player //Player 클래스의 정의. 자기 자신 접근자
{
    //클래스 안에 선언된 변수 : 멤버 변수 -> 속성을 표시한다.
    //
    private int hp = 100; //private는 생략해도 무방
    private int power = 50;
    public int score;

    //플레이어의 공격
    public void Attack()
    {
        Debug.Log(this.power + "데미지를 입혔다");
    }

    //플레이어의 피격
    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "를 입었다");
        Debug.Log("나의 HP는" +this.hp+"가 되었다.");
    }
}
// public : 아무데나 접근가능 / C#은 클래스의 묶음으로 실행되는 객체지향적인 언어
public class study01 : MonoBehaviour
//C#은 {}로 코드의 구역을 구분한다.
//study01이라는 이름의 클래스를 만들었다.
// : MonoBehaviour -> study01이라는 클래스는 MonoBehaviour를 상속받았다.
// : MonoBehaviour : 유니티 엔진 오브젝트들을 컨트롤 할 수 있는 기능이 들어있는 클래스
// 유니티에서는 코드의 파일명과 모노비헤비어를 상속받는
// 클래스의 이름이 일치해야 제대로 작동한다.
{
    // Start is called before the first frame update
    // void Start(), void Update() 둘 다 C#의 함수(메서드)이다.
    // Start() : 앱이 실행될 때 실행되는 함수
    // update() : 매 프레임마다 실행되는 함수 

    void SayHello()
    {
        Debug.Log("Hello");
    }
    void CallName(string name)
    {
        Debug.Log("Hello " + name);
    }
    int Add(int a, int b)
    {
        int c = a + b;
        return c;
    }
    void Start()
    {
        Player myPlayer = new Player(); //클래스에서 객체 생성하기
        //클래스이름() : 클래스의 생성자라는 메서드
        //new : 새로운 메모리 공간을 할당을 했다.
        myPlayer.Attack(); //생성한 객체의 메서드 호출
        //myplayer라는 '객체'가 공격(Attack)이라는 '행동'을 한다
        myPlayer.Damage(30);
        //myplayer라는 '객체'가 30의 값으로 피격(Damage)받는 '행동'을 한다

           print("아아아아");
           /*
           1) 기본적으로 유니티는 모든 변수의 앞에 변수형을 지정해 줘야 한다.
           2) 한번 지정된 변수형은 바뀔 수 없다.
           3) 모든 변수를 선언 or 초기화 한 후 사용해야 한다.
           */
           int age; //age라는 이름의 int 정수 형태의 변수를 선언을 한 후
           age = 30; //age 안에 30이라는 값을 넣고
           Debug.Log(age); //age를 출력한다.
           string name = "오형규"; //선언과 동시에 초기값을 넣어서 초기화를 할 수도 있다.
           Debug.Log(name);
           float a = 160.5f;
        //소수점이 있는 숫자(실수)를 표시하는 대표적인 자료형은 float이랑 double이 있는데
        //float은 4바이트고 double은 8바이트
        //C#에서는 double이 기본형
        //4바이트짜리 float형 실수값이다를 표시해 줄 때 숫자 뒤에 f를 붙인다.
        //변수의 선언과 초기화의 개념
        //선언은 변수 쓰겠다 예약
        //처음부터 값을 넣어서 만들때 초기화 사용
        /* 조건문 ( if, switch )
        switch문 : 특정한 변수의 값을 체크해서 값에 따라 결과를 실행하는 구문
        switch (변수)
        {
           case 변수값 :
                실행문;
                break;
           case 변수값 :
                실행문;
                break;
           default 변수값 :
                   실행문;
                   break;
        }

        string grade;
        grade = "";

        switch (grade)
        {
            case "A": //A일경우
                print("장학금 100만원");
                break; //break는 사실 모든 코드에서 사용될 수 있음
                       //break : 해당 코드 구역을 탈출하라
            case "B": //B일경우
                print("장학금 50만원");
                break;
            default: //기본값은
                print("장학금 없음");
                break;
        }
        */

        /* 반복문 ( while, for, foreach, do while : repeat와 같음 )
        1) for문
        for(초기식;조건식;증감식)
        {
        반복되어 실행되는 실행문
        }
        초기식에서 시작해서 증감식을 적용하면서
        조건식을 만족할 때까지 실행문을 반복해라.

        for(int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }
        for (int i = 0; i < 10; i += 2)
        {
            Debug.Log(i);
        }
        for (int i = 3; i <=5; i++)
        {
            Debug.Log(i);
        }
        for (int i = 3 ;i >= 0 ; i--)
        {
            Debug.Log(i);
        }
        int hp = 1;
        if (hp <= 50)
        {
        Debug.Log("도망!");
        }
        else if (hp >= 200)
        {
        Debug.Log("공격!");
        }
        else
        {
        Debug.Log("방어!");
        }
        */
        /*배열
        연번으로 구성된 크기가 고정된 데이터
        */
        string[] students = new string[30];
        //배열의 선언
        //30개짜리 연번을 가진 student라는 배열 변수를 사용하겠다.
        // 1~30이 아니라 0~29까지 30개.
        students[4] = "탈주자";
        students[0] = "고건혁";
        print(students[0]);
        int[] array = new int[5];

        array[0] = 2;
        array[1] = 10;
        array[2] = 5;
        array[3] = 15;
        array[4] = 3;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        int[] points = { 83, 99, 52, 93, 15 };

        for (int i = 0; i < points.Length; i++)
        {
            if (points[i] >=90)
            {
                Debug.Log(points[i]);
            }
        }

        SayHello();

        CallName("Tom");

        int answer;
        answer = Add(2, 3);
        Debug.Log(answer);
    }
    

   
       
    
    // Update is called once per frame
    void Update()
    {
        //print("무야호");
    }
    /* 유니티의 주요 생명주기 함수
    Awake : 모든 오브젝트가 초기화된 후 한 번 호출
    -> Start : 첫 프레임이 업데이트 되기 전의 타이밍에 호출
    Update : 매 프레임마다 호출
    FixedUpdate : 호출 주기가 일정한 함수
    LateUpdate : 매 프레임이 끝날 때마다 호출
    */
}

// 한줄 짜리 주석

/* 여러 줄 짜리 주석
 여러 줄 짜리
 */
/* C#이란???
    .NET Framework : MS에서 개발한 플랫폼 독립적 개발 환경
    C#, C++, Visual Basic 기타 등등
    닷넷 언어끼리는 기본적인 언어 규약이 공통되는 것들이 있고
    데이터의 형식이 공유된다.

    C#이 가지는 표현적 특징
    1) 대소문자를 정확히 구분한다. you YOU
    2) C#은 띄어쓰기로 요소를 구분한다.
    3) C#은 반드시 실행문의 끝에 ;을 붙여줘야 한다.
    */