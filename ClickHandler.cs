using UnityEngine;
using UnityEngine.EventSystems;

public class ClickHandler : MonoBehaviour
{
    public GameObject obj1; // ระบุ obj1 ใน Inspector

    public void OnClickUI()
    {
        // Check if the mouse is over UI
        if (EventSystem.current.IsPointerOverGameObject())
        {
            // Do UI-related actions here

            // Disable interaction with obj1
            obj1.GetComponent<Collider>().enabled = false;
        }
    }
}
