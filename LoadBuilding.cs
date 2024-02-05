using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadBuilding : MonoBehaviour
{
    public string SceneToLoad;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public int exitbuilding;


    private void Start()
    {
        exitbuilding = PlayerPrefs.GetInt("exitbuilding", 0);

        Debug.Log(exitbuilding);
    }
    private void Update()
    {
        exitbuilding = PlayerPrefs.GetInt("exitbuilding", 0);
        if (exitbuilding == 1)
        {
            obj1.GetComponent<Collider2D>().enabled = true;
           obj2.GetComponent<Collider2D>().enabled = true;
            obj3.GetComponent<Collider2D>().enabled = true;
            PlayerPrefs.DeleteKey("exitbuilding");

        }

    }

    void OnMouseDown()
    {
        // เรียกเมธอดเพื่อเปลี่ยน Scene

        

        gameObject.GetComponent<LoadScene>().PlayScene(SceneToLoad);
        obj1.GetComponent<Collider2D>().enabled = false;
        obj2.GetComponent<Collider2D>().enabled = false;
        obj3.GetComponent<Collider2D>().enabled = false;

        PlayerPrefs.DeleteKey("exitbuilding");
        PlayerPrefs.SetInt("exitbuilding", 0);
    }


}
