using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Image menu;
    private bool open = false;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;

    void Start()
    {
        // ซ่อน menu เมื่อเริ่มเกม
        menu.gameObject.SetActive(false);
    }

    public void ToggleMenu()
    {
        open = !open; // สลับสถานะ

        menu.gameObject.SetActive(open); // ใช้ open ในการกำหนดค่าการแสดง/ซ่อน
        obj1.GetComponent<Collider2D>().enabled = !open;
        obj2.GetComponent<Collider2D>().enabled = !open;

        obj3.GetComponent<Collider2D>().enabled = !open;


    }
}
