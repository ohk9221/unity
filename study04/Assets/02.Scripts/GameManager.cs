using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    //���� ���
    void Awake()
    {
        Instance = this; 
    }
    //���ӸŴ����� ������ ��Ҹ� �����Ϸ���
    //���ӸŴ����� ������ ��� ��Ҹ� �Ӽ�(�������)�� ��� ������ �ȴ�.

    //������(Ŭ����)��
    public GameObject playerPrefab;
    public GameObject animalPrefab;
    public GameObject boxPrefab;
    public GameObject itemPrefab;

    //���� �ȿ��� ����� ��ü ������Ʈ��
    GameObject player;
    GameObject[] animals;
    GameObject[] boxes;
    GameObject[] items;
    item[] itemData;

    //���� �ȿ��� ����� ��ü UI ������Ʈ��
        //�÷��̾� �̸�
        //�÷��̾� ���
        //�÷��̾� ü��
        //�÷��̾� �����
        //������ ���
        //�ý��� �޽���

    // Start is called before the first frame update
    void Start()
    {
        InitializeGameData(); //���� ������ �ʱ�ȭ

    }

    // Update is called once per frame
    void Update()
    {
        //�÷��̾� �̵�
        player.GetComponent<PlayerClass>().Move();
    }

    void InitializeGameData() //���� ������ �ʱ�ȭ
    {
        //�����۵����͸���Ʈ ����
        itemData = new item[5];
        itemData[0] = new item("ġŲ",0,10,0,0,0,0.5f);
        itemData[1] = new item("¯��",1,0,0,0,3,1.0f);
        itemData[2] = new item("Ŀ��",2,3,10,0,0,0.3f);
        itemData[3] = new item("�ҵ���",3,0,0,10,0,0.7f);
        itemData[4] = new item("���",4,5,5,5,5,3.0f);

        /*
         ������ �߸Ŷ� �̷��� ������ ������ �����͸� �о�ͼ� �����ؾ� ��
         */

        //��ü�� �����ϰ� ��ġ�ϴ� �ڵ�
        //�÷��̾� ������Ʈ ����
        player = GameObject.FindGameObjectWithTag("Player");

        //���� ������Ʈ ����
        boxes = GameObject.FindGameObjectsWithTag("Box");

        //���� �� ���� ����
        generateAnimal(3);
        
    }

    void InitializeUI() //UI �ʱ�ȭ
    {

    }
    void generateAnimal(int amount) //���� ���� (�Ű����� : ���� �� )
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject instantAnimal = Instantiate(animalPrefab);
            instantAnimal.transform.position = new Vector3(Random.Range(0, 5), 0.5f, Random.Range(0, 5));
        }
        animals = GameObject.FindGameObjectsWithTag("Animal");
    }

    public void generateItem(int itemID,GameObject other)
    {        
        GameObject instantItem = Instantiate(itemPrefab);
        instantItem.GetComponent<ItemClass>().itemData = itemData[itemID];
        instantItem.name = instantItem.GetComponent<ItemClass>().itemData.name;
        instantItem.transform.position = other.transform.position;
        print("��������" + instantItem.name);
    }

}

public class item
{
    public string name;
    public int id;
    public int hungerBonus;
    public int staminaBonus;
    public int hpBonus;
    public int attBonus;
    public float weight;

    public item()
    {

    }

    public item(string name, int id, int hungerBonus, int staminaBonus, int hpBonus, int attBonus, float weight)
    {
        this.name = name;
        this.id = id;
        this.hungerBonus = hungerBonus;
        this.staminaBonus = staminaBonus;
        this.hpBonus = hpBonus;
        this.attBonus = attBonus;
        this.weight = weight;
    }
}