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
        // ซ่อน menu เมื่อเริ่มเกม
        menu.gameObject.SetActive(false);
    }

    public void ToggleMenu()
    {
        open = !open; // สลับสถานะ

        menu.gameObject.SetActive(open); // ใช้ open ในการกำหนดค่าการแสดง/ซ่อน
        

    }
}
