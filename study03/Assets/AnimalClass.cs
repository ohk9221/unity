using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//열거형이란 : enum - 
public enum animalType {rabbit, deer, wolf}

public class AnimalClass : MonoBehaviour
{
    //속성
    string animalName;
    int id;
    animalType animaltype;
    int HP;
    int att;
    int spd;
    item[] item;

    //행동
    //이동
    public void Move()
    {
        
    }
    //공격
    public void Attack() //매개변수는 플레이어
    {

    }
    //아이템을 결정
    public item SetItem() //매개변수는 아이템의 배열, 반환값은 아이템
    {
        item myItem = new item();
        return myItem;
    }
}
