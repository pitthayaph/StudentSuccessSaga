using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene: MonoBehaviour
{
    // ���ҧ��������͡�˹����� Scene ���س��ͧ�������¹�
    public string ChangeToScene;
    void OnMouseDown()
    {
        // ���¡���ʹ��������¹ Scene
        SwitchScene();
    }


    public void SwitchScene()
    {
        // �� SceneManager.LoadScene ��������¹ Scene
        SceneManager.LoadScene(ChangeToScene);
    }
}
