using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class PlayerClass : MonoBehaviour
{
    //속성
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

    //행동
    //이동
    public void Move()
    {

    }

    //탐색
    public item Search() //매개변수는 상자, 반환값은 아이템
    {
        item myItem = new item();
        return myItem;  
    }

    //사냥
    public item Hunt() //매개변수는 동물, 반환값은 아이템
    {
        item myItem = new item();
        return myItem;
    }

    //아이템 획득
    public item GetItem() //매개변수는 동물이나 아이템, 반환값은 아이템
    {
        item myItem = new item();
        return myItem;
    }

    //아이템 사용
    public void UseItem() //매개변수는 아이템, 반환값은 없음
    {
        //아이템 효과 적용
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
