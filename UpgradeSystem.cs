using UnityEngine;

public class UpgradeSystem : MonoBehaviour
{
    public int money;
    public int amount;
    public int tableLevel;
    public GameObject table;
    public GameObject tableLevel1;
    public int price = 200;
    public int bedLevel;
    public GameObject bed;
    public GameObject bedLevel1;


    private void Update()
    {
        money = PlayerPrefs.GetInt("PlayerMoney");
    }

    public void Upgradetable()
    {
        if (tableLevel == 0)
        {
            if (money >= price)  // ��䢷���� ����¹����ͧ�����ҡ����������ҡѺ
            {
                amount = money - price;
                table.gameObject.SetActive(false);
                tableLevel1.gameObject.SetActive(true);
                tableLevel = 1;
                Debug.Log(money);
                PlayerPrefs.SetInt("PlayerMoney", amount);
                Debug.Log(amount);  // ��䢷���� ����¹�ҡ Debug.Log(money) �� Debug.Log(amount)
            }
        }
        else
        {
            Debug.Log(money);
        }
       
    }

    public void Upgradebed ()
    {
        if (bedLevel == 0)
        {
            if (money >= price)  // ��䢷���� ����¹����ͧ�����ҡ����������ҡѺ
            {
                amount = money - price;
                bed.gameObject.SetActive(false);
                bedLevel1.gameObject.SetActive(true);
                bedLevel = 1;
                Debug.Log(money);
                PlayerPrefs.SetInt("PlayerMoney", amount);
                Debug.Log(amount);  // ��䢷���� ����¹�ҡ Debug.Log(money) �� Debug.Log(amount)
            }
        }
        else
        {
            Debug.Log(money);
        }
    }
}
