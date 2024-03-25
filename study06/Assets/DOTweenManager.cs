using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI ������Ʈ �����ϴ� ���ӽ����̽�
using TMPro; //tmpro ����ϴ� ���ӽ����̽�
using DG.Tweening; //��Ʈ���� ����ϴ� ���ӽ����̽�

public class DOTweenManager : MonoBehaviour
{
    // �Ŵ����� �ڵ� �ۼ� �� ������� ����

    // �ƿ��� �������� ����� �� ������Ʈ�� ������Ʈ
    public GameObject textTestButton;
    //public TMP_Text TestText; //TMP_Text : TextMesh Pro�� text ������Ʈ �̿�
    public Text testText;
    public RectTransform testImage;
    public Image test2;

    // �ƿ��� �������� ����� �� �����յ�
    // �Ŵ����� �����ϴµ� �ʿ��� �Ӽ���
    p


    public void DOTweenText(Text _text) //��Ʈ���� ����� �ؽ�Ʈ ��Ʈ��
    {
        _text.text = "";
        _text.DOText("���� �����Դ�", 1f); //to
        _text.DOColor(new Color(100 / 255f, 0/ 255f, 0/ 255f), 2f);
        //��Ʈ���� �Լ��� ���������� ������� �ʰ� ���ÿ� ����ȴ�.
    }

    public void DOTweenTransform(RectTransform _rect)
    {
        //_rect.DOScale(new Vector3(2, 2, 2), 3f); //Doscale(�ٲ�ũ��, ����ð�)
        //_rect.DORotate(new Vector3(0, 0, 90), 2f, RotateMode.FastBeyond360); //�ٲ𰢵�, ����ð�, ȸ�����
        //_rect.DOAnchorPos(new Vector2(0, 0), 2f); // �̵�����ǥ,����ð�
        //_rect.DOPunchScale(new Vector3(1, 1, 1), 1f, 3, 1f); // ũ��,����ð�,����,ź�¼�
        //_rect.DOShakeAnchorPos(1f, new Vector2(100, 100), 100, 90); // ����ð�, ������ũ��, ��������, ��������
    }

    public void SequenceTest()
    {
        //��Ʈ���� ��������� ���·� ���� ������ ����
        //�� �������� ����� -> ���� �������� ������ �Լ����� ������� ä���ְ� ( ������ ���� �ϼ� )
        //���۵� �������� �÷��� -> ������� �ʴ� �������� Kill�Ѵ�. (�⺻�� AutoKill�� �ڵ����� �׿��ش�.)

        //�� ������ �����
        testSeq = DOTween.Sequence(); //testSeq��� �� �������� ���������.
        testSeq.SetAutoKill(false)
        //�� ���� ���� �� testSeq.Kill();�� �ش� �������� �׿������Ѵ�.
        //testSeq.Pause(); //���� �������� �������ѳ��´�.

        //�������� ����ִ� �������� �Լ� �ֱ�
        //Append : �������� �� ���� �Լ��� �߰�
        //Insert : Ư�� ��ġ�� ����ִ´�.(�Լ� �߰��� �����ֱ�)
        //Join : ���� �Լ��� ���ÿ� ����ǰ� �Ѵ�
        //Prepend : �������� �� �տ� �Լ��� �߰�
        //AppendInterval : �������� �� ���� ������ �ð��� �ִ´�
        //Insert�� Interval�� ������ ���� �ʴ´�.
        //PrependInterval : �������� �� �տ� ������ �ð��� �ִ´�
        //AppendCallback : ��Ʈ���� �ƴ� �ٸ� �Լ��� ȣ���ϰ� ���� ��
        testSeq.Append(testImage.DOScale(new Vector3(2, 2, 2), 3f)); // �������� �� �տ� ����
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
