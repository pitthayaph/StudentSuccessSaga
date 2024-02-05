using UnityEngine;

public class Player : MonoBehaviour
{
    public int money = 100 ;
    public int level = 1;
    public int knowledge = 1;
    public int health = 1; 
    public int relationship = 1;
    public ProgressBar progressBar;
    public int click;
    public int progress = 1;
    public int move;


    private void Start()
    {
        PlayerPrefs.DeleteKey("click");
        PlayerPrefs.DeleteKey("MyVariable");

        click = PlayerPrefs.GetInt("click",100);
        move = PlayerPrefs.GetInt("hasmove", 200);
        PlayerPrefs.SetInt("PlayerMoney", 1000);
        PlayerPrefs.SetInt("PlayerKnowledge", 1);



        Debug.Log(click);
        Debug.Log(move);
    }

    private void Update()
    {
        if (progressBar != null)
        {
            knowledge = PlayerPrefs.GetInt("PlayerKnowledge");
            progressBar.current = knowledge;
        }
    }
    void SavePlayer()
    {
        PlayerPrefs.SetInt("PlayerMoney", money);
        PlayerPrefs.SetInt("PlayerLevel", level);
        PlayerPrefs.SetInt("PlayerKnowledge", knowledge);
        PlayerPrefs.SetInt("PlayerHealth", health);
        PlayerPrefs.SetInt("PlayerRelationship", relationship);


        // ตัวแปรอื่น ๆ ที่ต้องการบันทึก

        PlayerPrefs.Save();
    }

    void LoadPlayer()
    {
        money = PlayerPrefs.GetInt("PlayerMoney", 100);
        level = PlayerPrefs.GetInt("PlayerLevel", 1);
        knowledge = PlayerPrefs.GetInt("PlayerKnowledge", 1);
        health = PlayerPrefs.GetInt("PlayerHealth", 1);
        relationship = PlayerPrefs.GetInt("PlayerRelationship", 1);


        if (progressBar != null)
        {
            progressBar.current = knowledge;
        }

        // ตัวแปรอื่น ๆ ที่ต้องการโหลด
    }
}
