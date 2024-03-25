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
    //item[] myItem;
    List<item> myItem;
    item weapon;
    float maxWeight;
    float currentWeight;

    //�̵� ��� ���� �Ӽ�
    float moveX, moveY;

    //�ൿ
    //�̵�
    public void Move()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        gameObject.transform.Translate(new Vector3(moveX* 0.01f,0, moveY* 0.01f));
    }

    //Ž��
    public int Search(GameObject box) //�Ű������� ���� , ��ȯ���� ������ ID
    {
    
        print("ã����!" + box.name);
        int myItem = box.GetComponent<BoxClass>().SetItem();
        print(myItem);
        Destroy(box);
        return myItem;
    }

    //���
    public int Hunt(GameObject animal) //�Ű������� ����, ��ȯ���� ������ ID
    {
        print("�������!" + animal.name);
        int myItem = animal.GetComponent<AnimalClass>().SetItem();
        print(myItem);
        Destroy(animal);
        return myItem;
    }

    //������ ȹ��
    public item GetItem(GameObject itemObj) //�Ű������� ������, ��ȯ���� �����۵�����
    {
        print("������ �Ծ���");
        item addItem = new item();
        addItem.name = itemObj.GetComponent<ItemClass>().itemData.name;
        addItem.id = itemObj.GetComponent<ItemClass>().itemData.id;
        addItem.hungerBonus = itemObj.GetComponent<ItemClass>().itemData.hungerBonus;
        addItem.staminaBonus = itemObj.GetComponent<ItemClass>().itemData.staminaBonus;
        addItem.hpBonus = itemObj.GetComponent<ItemClass>().itemData.hpBonus;
        addItem.attBonus = itemObj.GetComponent<ItemClass>().itemData.attBonus;
        addItem.weight = itemObj.GetComponent<ItemClass>().itemData.weight;
        print(addItem.name);
        Destroy(itemObj);
        return addItem;
    }

    //������ ���
    public void UseItem() //�Ű������� ������,��ȯ���� ����
    {
        print("������ ����!");
        //������ ȿ�� ����
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Animal")
        {
            //other.gameObject.GetComponent<AnimalClass>().SetItem();            
            GameManager.Instance.generateItem(Hunt(other.gameObject),other.gameObject);
        }
        else if (other.gameObject.tag == "Box")
        {
            //other.gameObject.GetComponent<BoxClass>().SetItem();
            GameManager.Instance.generateItem(Search(other.gameObject), other.gameObject);            
        }
        else if(other.gameObject.tag == "Item" && other.gameObject.GetComponent<ItemClass>().isTouched == false)
        {
            if(other.gameObject != null)
            {
                other.gameObject.GetComponent<ItemClass>().isTouched = true;
                myItem.Add(GetItem(other.gameObject));
            }
        }
    }
}