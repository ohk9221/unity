using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//�������̶� : enum - 
public enum animalType {rabbit, deer, wolf }

public class AnimalClass : MonoBehaviour
{
    //�Ӽ�
    string animalName;
    int id;
    public animalType animaltype;
    int HP;
    int att;
    int spd;

    //�ൿ
    //�̵�
    public void Move()
    {

    }
    //����
    public void Attack() //�Ű������� �÷��̾�
    {

    }

    //�������� ���� ( ������ ������������ ������ ���� )
    public int SetItem() //��ȯ���� ������ ID
    {
        return Random.Range(0, 4);
    }

    void Start()
    {
        this.animaltype = (animalType)Random.Range(0, 2);
        gameObject.name = this.animaltype.ToString();
    }
}
