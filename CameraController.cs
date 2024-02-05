using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float zoomSpeed = 5f;
    public float dragSpeed = 2f;
    public float minZoom = 1f;
    public float maxZoom = 10f;
    public float minX = -10f;
    public float minY = -10f;

    private Vector3 dragOrigin;

    void Update()
    {
        // การซูม
        float scrollValue = Input.GetAxis("Mouse ScrollWheel");
        float currentZoom = Camera.main.orthographicSize;
        float newZoom = currentZoom - scrollValue * zoomSpeed * Time.deltaTime;
        newZoom = Mathf.Clamp(newZoom, minZoom, maxZoom);
        Camera.main.orthographicSize = newZoom;

        // การลาก
        if (Input.GetMouseButtonDown(0))
        {
            dragOrigin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            return;
        }

        if (!Input.GetMouseButton(0)) return;

        Vector2 dragDelta = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)dragOrigin;
        Vector2 moveDelta = -dragDelta * dragSpeed * Time.deltaTime;

        // คำนวณตำแหน่งของกล้องหลังจากการลาก
        Vector3 newPosition = transform.position + new Vector3(moveDelta.x, moveDelta.y, 0);

        // ใช้ Mathf.Clamp เพื่อจำกัดตำแหน่งของกล้องในเกม
        float maxX = Mathf.Clamp(newPosition.x, minXByZoom(currentZoom), maxXByZoom(currentZoom));
        float maxY = Mathf.Clamp(newPosition.y, minYByZoom(currentZoom), maxYByZoom(currentZoom));

        // ขยับกล้อง
        transform.position = new Vector3(maxX, maxY, newPosition.z);

        dragOrigin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    float maxXByZoom(float currentZoom)
    {
        // ตั้งค่า max X ที่คำนวณจากค่า currentZoom
        return  (5f - currentZoom);
    }

    float maxYByZoom(float currentZoom)
    {
        // ตั้งค่า max Y ที่คำนวณจากค่า currentZoom
        return  (5f - currentZoom);
    }

    float minXByZoom(float currentZoom)
    {
        // ตั้งค่า max X ที่คำนวณจากค่า currentZoom
        return ( currentZoom -5f);
    }

    float minYByZoom(float currentZoom)
    {
        // ตั้งค่า max Y ที่คำนวณจากค่า currentZoom
        return ( currentZoom -5f);
    }
}
