using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//�������̶� : enum - 
public enum animalType {rabbit, deer, wolf}

public class AnimalClass : MonoBehaviour
{
    //�Ӽ�
    string animalName;
    int id;
    animalType animaltype;
    int HP;
    int att;
    int spd;
    item[] item;

    //�ൿ
    //�̵�
    public void Move()
    {
        
    }
    //����
    public void Attack() //�Ű������� �÷��̾�
    {

    }
    //�������� ����
    public item SetItem() //�Ű������� �������� �迭, ��ȯ���� ������
    {
        item myItem = new item();
        return myItem;
    }
}
