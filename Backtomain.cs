using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Backtomain : MonoBehaviour
{

    public string SceneToUnload;
    public void backtomain()
    {
        // เรียกเมธอดเพื่อปิด Scene "PienVichit"
        gameObject.GetComponent<LoadScene>().UnloadScene(SceneToUnload);
        // หลังจากปิด Scene "PienVichit" ให้กลับไปที่ Scene หลัก

        PlayerPrefs.SetInt("exitbuilding", 1);

    }
}
