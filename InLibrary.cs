using UnityEngine;
using UnityEngine.SceneManagement;

public class InLibrary : MonoBehaviour
{
    public float moveSpeed = 5f;
    public int myVariable;
    private float distanceleft = 0f;
    public int hasMove;
    public int firstclick;

    private void Awake()
    {
        firstclick = PlayerPrefs.GetInt("click", 1);
        checkclick();
        inBuild();





    }
    public void checkclick()
    {
        myVariable = PlayerPrefs.GetInt("Library");

        if (firstclick == 2 & myVariable == 70)
        {
            PlayerPrefs.SetInt("hasmove", 3);
            PlayerPrefs.DeleteKey("Library");


        }
    }

    private void Update()
    {
        walkleft();
    }

    private void inBuild()
    {
        hasMove = PlayerPrefs.GetInt("hasmove");
        PlayerPrefs.SetInt("click", 2);


        if (hasMove == 3)
        {
            transform.position = new Vector2(-3.2f, -3.4f);
            PlayerPrefs.DeleteKey("firstclick");
            PlayerPrefs.DeleteKey("hasmove");


        }
    }

    public void walkleft()
    {
        myVariable = PlayerPrefs.GetInt("Library");
        hasMove = PlayerPrefs.GetInt("hasmove");




        if (hasMove != 3 && myVariable == 70)
        {
            // เคลื่อนที่ GameObject ไปทางขวา
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
            distanceleft += moveSpeed * Time.deltaTime;
            if (distanceleft >= 13.5f)
            {
                PlayerPrefs.SetInt("hasmove", 2);
                PlayerPrefs.DeleteKey("Library");



            }
        }




    }


}
