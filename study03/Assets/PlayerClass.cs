using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class PlayerClass : MonoBehaviour
{
    //�Ӽ�
    string playerName;
    int id;
    int hunger;
    int stamina;
    int HP;
    int att;
    item[] myItem;
    item[] weapon;
    float maxWeight;
    float currenWeight;

    //�ൿ
    //�̵�
    public void Move()
    {

    }

    //Ž��
    public item Search() //�Ű������� ����, ��ȯ���� ������
    {
        item myItem = new item();
        return myItem;  
    }

    //���
    public item Hunt() //�Ű������� ����, ��ȯ���� ������
    {
        item myItem = new item();
        return myItem;
    }

    //������ ȹ��
    public item GetItem() //�Ű������� �����̳� ������, ��ȯ���� ������
    {
        item myItem = new item();
        return myItem;
    }

    //������ ���
    public void UseItem() //�Ű������� ������, ��ȯ���� ����
    {
        //������ ȿ�� ����
    }
    public void DeleteItem()
    {

    }
}

public class item
{
    string name;
    int hungerBonus;
    int staminaBonus;
    int hpBonus;
    int attBonus;
    float weight;
}
