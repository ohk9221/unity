using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum boxType { paperBox, woodBox, cabinet, vault }
public class BoxClass : MonoBehaviour
{
    int id;
    boxType boxType;
    bool isOpen;
    item[] item; //����� �� �ִ� �������� ����
    int size; //�������� ũ�� == ������ ����Ǵ� ����
    int reqStamina;

    //�ൿ
    //�������� ����
    public item SetItem() //�Ű������� �������� �迭, ��ȯ���� ������
    {
        item myItem = new item();
        return myItem;
    }
}
