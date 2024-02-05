using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public float zoomSpeed = 5f;
    public float minZoom = 1f;
    public float maxZoom = 10f;

    void Update()
    {
        float scrollValue = Input.GetAxis("Mouse ScrollWheel");

        // คำนวณการซูม
        float newZoom = Camera.main.orthographicSize - scrollValue * zoomSpeed * Time.deltaTime;

        // จำกัดขอบเขตของการซูม
        newZoom = Mathf.Clamp(newZoom, minZoom, maxZoom);

        // กำหนดค่าการซูมให้กับ Camera
        Camera.main.orthographicSize = newZoom;
    }
}
