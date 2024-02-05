using UnityEngine;
using System.Collections;
public class testcollider : MonoBehaviour
{
    public bool inBuilding;
   


   
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Building")
        {
            transform.position = new Vector2(-30f, 0f);

            StartCoroutine(WaitAndSave());
        }
    }

    IEnumerator WaitAndSave()
    {
        yield return new WaitForSeconds(5f);

        // ทำสิ่งที่คุณต้องการหลังจากผ่านไป 5 วินาที
        
        inBuilding = true;

        // บันทึกค่าใน PlayerPrefs
        
        PlayerPrefs.DeleteKey("PienVichit");
        PlayerPrefs.SetInt("PienVichit", 70);
    }
}
