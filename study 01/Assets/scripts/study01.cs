using System.Collections;
// using : System.Collections��� �̸��� ���ӽ����̽��� ����ϰڴ�.
// ���ӽ����̽� : ���� '�ڵ��� ����'�̴�.
using System.Collections.Generic;
using UnityEngine;
// using���� �߰��� ���� ����ϰ� �ִ� �� ������, ������� �ʰ� �ִ� ���� ȸ������ ǥ�õ�
public class Player //Player Ŭ������ ����. �ڱ� �ڽ� ������
{
    //Ŭ���� �ȿ� ����� ���� : ��� ���� -> �Ӽ��� ǥ���Ѵ�.
    //
    private int hp = 100; //private�� �����ص� ����
    private int power = 50;
    public int score;

    //�÷��̾��� ����
    public void Attack()
    {
        Debug.Log(this.power + "�������� ������");
    }

    //�÷��̾��� �ǰ�
    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "�� �Ծ���");
        Debug.Log("���� HP��" +this.hp+"�� �Ǿ���.");
    }
}
// public : �ƹ����� ���ٰ��� / C#�� Ŭ������ �������� ����Ǵ� ��ü�������� ���
public class study01 : MonoBehaviour
//C#�� {}�� �ڵ��� ������ �����Ѵ�.
//study01�̶�� �̸��� Ŭ������ �������.
// : MonoBehaviour -> study01�̶�� Ŭ������ MonoBehaviour�� ��ӹ޾Ҵ�.
// : MonoBehaviour : ����Ƽ ���� ������Ʈ���� ��Ʈ�� �� �� �ִ� ����� ����ִ� Ŭ����
// ����Ƽ������ �ڵ��� ���ϸ�� ������� ��ӹ޴�
// Ŭ������ �̸��� ��ġ�ؾ� ����� �۵��Ѵ�.
{
    // Start is called before the first frame update
    // void Start(), void Update() �� �� C#�� �Լ�(�޼���)�̴�.
    // Start() : ���� ����� �� ����Ǵ� �Լ�
    // update() : �� �����Ӹ��� ����Ǵ� �Լ� 

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
        Player myPlayer = new Player(); //Ŭ�������� ��ü �����ϱ�
        //Ŭ�����̸�() : Ŭ������ �����ڶ�� �޼���
        //new : ���ο� �޸� ������ �Ҵ��� �ߴ�.
        myPlayer.Attack(); //������ ��ü�� �޼��� ȣ��
        //myplayer��� '��ü'�� ����(Attack)�̶�� '�ൿ'�� �Ѵ�
        myPlayer.Damage(30);
        //myplayer��� '��ü'�� 30�� ������ �ǰ�(Damage)�޴� '�ൿ'�� �Ѵ�

           print("�ƾƾƾ�");
           /*
           1) �⺻������ ����Ƽ�� ��� ������ �տ� �������� ������ ��� �Ѵ�.
           2) �ѹ� ������ �������� �ٲ� �� ����.
           3) ��� ������ ���� or �ʱ�ȭ �� �� ����ؾ� �Ѵ�.
           */
           int age; //age��� �̸��� int ���� ������ ������ ������ �� ��
           age = 30; //age �ȿ� 30�̶�� ���� �ְ�
           Debug.Log(age); //age�� ����Ѵ�.
           string name = "������"; //����� ���ÿ� �ʱⰪ�� �־ �ʱ�ȭ�� �� ���� �ִ�.
           Debug.Log(name);
           float a = 160.5f;
        //�Ҽ����� �ִ� ����(�Ǽ�)�� ǥ���ϴ� ��ǥ���� �ڷ����� float�̶� double�� �ִµ�
        //float�� 4����Ʈ�� double�� 8����Ʈ
        //C#������ double�� �⺻��
        //4����Ʈ¥�� float�� �Ǽ����̴ٸ� ǥ���� �� �� ���� �ڿ� f�� ���δ�.
        //������ ����� �ʱ�ȭ�� ����
        //������ ���� ���ڴ� ����
        //ó������ ���� �־ ���鶧 �ʱ�ȭ ���
        /* ���ǹ� ( if, switch )
        switch�� : Ư���� ������ ���� üũ�ؼ� ���� ���� ����� �����ϴ� ����
        switch (����)
        {
           case ������ :
                ���๮;
                break;
           case ������ :
                ���๮;
                break;
           default ������ :
                   ���๮;
                   break;
        }

        string grade;
        grade = "";

        switch (grade)
        {
            case "A": //A�ϰ��
                print("���б� 100����");
                break; //break�� ��� ��� �ڵ忡�� ���� �� ����
                       //break : �ش� �ڵ� ������ Ż���϶�
            case "B": //B�ϰ��
                print("���б� 50����");
                break;
            default: //�⺻����
                print("���б� ����");
                break;
        }
        */

        /* �ݺ��� ( while, for, foreach, do while : repeat�� ���� )
        1) for��
        for(�ʱ��;���ǽ�;������)
        {
        �ݺ��Ǿ� ����Ǵ� ���๮
        }
        �ʱ�Ŀ��� �����ؼ� �������� �����ϸ鼭
        ���ǽ��� ������ ������ ���๮�� �ݺ��ض�.

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
        Debug.Log("����!");
        }
        else if (hp >= 200)
        {
        Debug.Log("����!");
        }
        else
        {
        Debug.Log("���!");
        }
        */
        /*�迭
        �������� ������ ũ�Ⱑ ������ ������
        */
        string[] students = new string[30];
        //�迭�� ����
        //30��¥�� ������ ���� student��� �迭 ������ ����ϰڴ�.
        // 1~30�� �ƴ϶� 0~29���� 30��.
        students[4] = "Ż����";
        students[0] = "�����";
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
        //print("����ȣ");
    }
    /* ����Ƽ�� �ֿ� �����ֱ� �Լ�
    Awake : ��� ������Ʈ�� �ʱ�ȭ�� �� �� �� ȣ��
    -> Start : ù �������� ������Ʈ �Ǳ� ���� Ÿ�ֿ̹� ȣ��
    Update : �� �����Ӹ��� ȣ��
    FixedUpdate : ȣ�� �ֱⰡ ������ �Լ�
    LateUpdate : �� �������� ���� ������ ȣ��
    */
}

// ���� ¥�� �ּ�

/* ���� �� ¥�� �ּ�
 ���� �� ¥��
 */
/* C#�̶�???
    .NET Framework : MS���� ������ �÷��� ������ ���� ȯ��
    C#, C++, Visual Basic ��Ÿ ���
    ��� ������ �⺻���� ��� �Ծ��� ����Ǵ� �͵��� �ְ�
    �������� ������ �����ȴ�.

    C#�� ������ ǥ���� Ư¡
    1) ��ҹ��ڸ� ��Ȯ�� �����Ѵ�. you YOU
    2) C#�� ����� ��Ҹ� �����Ѵ�.
    3) C#�� �ݵ�� ���๮�� ���� ;�� �ٿ���� �Ѵ�.
    */