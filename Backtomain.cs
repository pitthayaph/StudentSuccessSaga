using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Backtomain : MonoBehaviour
{

    public string SceneToUnload;
    public void backtomain()
    {
        // ���¡���ʹ���ͻԴ Scene "PienVichit"
        gameObject.GetComponent<LoadScene>().UnloadScene(SceneToUnload);
        // ��ѧ�ҡ�Դ Scene "PienVichit" ����Ѻ价�� Scene ��ѡ

        PlayerPrefs.SetInt("exitbuilding", 1);

    }
}
