using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene: MonoBehaviour
{
    // สร้างตัวแปรเพื่อกำหนดชื่อ Scene ที่คุณต้องการเปลี่ยนไป
    public string ChangeToScene;
    void OnMouseDown()
    {
        // เรียกเมธอดเพื่อเปลี่ยน Scene
        SwitchScene();
    }


    public void SwitchScene()
    {
        // ใช้ SceneManager.LoadScene เพื่อเปลี่ยน Scene
        SceneManager.LoadScene(ChangeToScene);
    }
}
