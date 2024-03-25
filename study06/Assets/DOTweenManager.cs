using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI 컴포넌트 제어하는 네임스페이스
using TMPro; //tmpro 사용하는 네임스페이스
using DG.Tweening; //닷트윈을 사용하는 네임스페이스

public class DOTweenManager : MonoBehaviour
{
    // 매니저류 코드 작성 시 멤버변수 세팅

    // 아웃렛 소켓으로 끌어다 쓸 오브젝트나 컴포넌트
    public GameObject textTestButton;
    //public TMP_Text TestText; //TMP_Text : TextMesh Pro의 text 컴포넌트 이용
    public Text testText;
    public RectTransform testImage;
    public Image test2;

    // 아웃렛 소켓으로 끌어다 쓸 프리팹들
    // 매니저를 제어하는데 필요한 속성들
    p


    public void DOTweenText(Text _text) //닷트윈을 사용한 텍스트 컨트롤
    {
        _text.text = "";
        _text.DOText("나는 오형규다", 1f); //to
        _text.DOColor(new Color(100 / 255f, 0/ 255f, 0/ 255f), 2f);
        //닷트윈의 함수는 순차적으로 실행되지 않고 동시에 실행된다.
    }

    public void DOTweenTransform(RectTransform _rect)
    {
        //_rect.DOScale(new Vector3(2, 2, 2), 3f); //Doscale(바뀔크기, 진행시간)
        //_rect.DORotate(new Vector3(0, 0, 90), 2f, RotateMode.FastBeyond360); //바뀔각도, 진행시간, 회전모드
        //_rect.DOAnchorPos(new Vector2(0, 0), 2f); // 이동할좌표,진행시간
        //_rect.DOPunchScale(new Vector3(1, 1, 1), 1f, 3, 1f); // 크기,진행시간,진동,탄력성
        //_rect.DOShakeAnchorPos(1f, new Vector2(100, 100), 100, 90); // 진행시간, 진동폭크기, 떨림정도, 랜덤정도
    }

    public void SequenceTest()
    {
        //닷트윈은 시퀀스라는 형태로 실행 순서를 제어
        //빈 시퀀스를 만들고 -> 만든 시퀀스에 실행할 함수들을 순서대로 채워넣고 ( 시퀀스 제작 완성 )
        //제작된 시퀀스를 플레이 -> 사용하지 않는 시퀀스는 Kill한다. (기본은 AutoKill로 자동으로 죽여준다.)

        //빈 시퀀스 만들기
        testSeq = DOTween.Sequence(); //testSeq라는 빈 시퀀스가 만들어진다.
        testSeq.SetAutoKill(false)
        //다 쓰고 나면 꼭 testSeq.Kill();로 해당 시퀀스를 죽여놔야한다.
        //testSeq.Pause(); //만든 시퀀스는 정지시켜놓는다.

        //만들어놓은 비어있는 시퀀스에 함수 넣기
        //Append : 시퀀스의 맨 끝에 함수를 추가
        //Insert : 특정 위치에 집어넣는다.(함수 중간에 끼워넣기)
        //Join : 앞의 함수와 동시에 실행되게 한다
        //Prepend : 시퀀스의 맨 앞에 함수를 추가
        //AppendInterval : 시퀀스의 맨 끝에 딜레이 시간을 넣는다
        //Insert는 Interval의 영향을 받지 않는다.
        //PrependInterval : 시퀀스의 맨 앞에 딜레이 시간을 넣는다
        //AppendCallback : 닷트윈이 아닌 다른 함수를 호출하고 싶을 때
        testSeq.Append(testImage.DOScale(new Vector3(2, 2, 2), 3f)); // 시퀀스의 맨 앞에 넣음
        testSeq.Append(test2.DOColor(new Color(100 / 255f, 0 / 255f, 0 / 255f), 2f));
        testSeq.Append(testImage.DORotate(new Vector3(0, 0, 90), 2f, RotateMode.FastBeyond360));
        testSeq.Insert(0.6f, testImage.DOAnchorPos(new Vector2(0, 0), 2f));
        /*
        testSeq.Play();
        testSeq.Pause();
        testSeq.Restart();
        testSeq.PlayBackwards();
        testSeq.Rewind();
        testSeq.Kill();
        */
    }

    public void PlaySequence()
    {
        testSeq.Play();
    }

    public void PauseSequence()
    {
        testSeq.Pause();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
