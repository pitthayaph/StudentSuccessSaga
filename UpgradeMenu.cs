using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeMenu : MonoBehaviour
{
    public Image menu;
    private bool open = false;
    

    void Start()
    {
        // ��͹ menu ������������
        menu.gameObject.SetActive(false);
    }

    public void ToggleMenu()
    {
        open = !open; // ��Ѻʶҹ�

        menu.gameObject.SetActive(open); // �� open 㹡�á�˹���ҡ���ʴ�/��͹
        

    }
}
