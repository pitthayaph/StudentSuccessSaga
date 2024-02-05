using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text moneyText; 
    
    public int money;

    

    void Update()
    {
        if (moneyText != null )
        {
            
            money = PlayerPrefs.GetInt("PlayerMoney");

            // แปลงเงินเป็นรูปแบบ "1k" เมื่อถึง 1000
            if (money >= 1000)
            {
                float moneyInK = money / 1000f;
                moneyText.text = moneyInK.ToString("0.#") + "k";
            }
            else
            {
                moneyText.text = money.ToString();
            }
        }
    }
}
