using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum boxType { paperBox,woodBox,cabinet,vault }

public class BoxClass : MonoBehaviour
{
    int id;
    public boxType boxType;
    bool isOpen;
    [SerializeField]
    int[] item; //����� �� �ִ� �������� ����(id)
    [SerializeField]
    int size; //�������� ũ�� == ������ ����Ǵ� ����
    [SerializeField]
    int reqStamina;

    public GameObject itemPrefab;

    //�ൿ
    //�������� ����
    public int SetItem() //�Ű������� �������� �迭(�ڱ� �ڽ��� �Ӽ��̹Ƿ� ���� �ʿ� ����), ��ȯ���� ������ id
    {
        return item[Random.Range(0, item.Length - 1)];
    }

    void Start()
    {
        gameObject.name = this.boxType.ToString();
    }
}
