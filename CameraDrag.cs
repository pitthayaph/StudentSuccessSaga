using UnityEngine;

public class CameraDrag : MonoBehaviour
{
    public float dragSpeed = 2f;
    public float minX = -10f;
    public float maxX = 10f;
    public float minY = -10f;
    public float maxY = 10f;

    private Vector3 dragOrigin;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dragOrigin = Input.mousePosition;
            return;
        }

        if (!Input.GetMouseButton(0)) return;

        Vector3 dragDelta = Input.mousePosition - dragOrigin;
        Vector3 moveDelta = new Vector3(-dragDelta.x, -dragDelta.y, 0) * dragSpeed * Time.deltaTime;

        // คำนวณตำแหน่งของกล้องหลังจากขยับ
        Vector3 newPosition = transform.position + moveDelta;

        // ใช้ Mathf.Clamp เพื่อจำกัดตำแหน่งของกล้องในเกม
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);

        // ขยับกล้อง
        transform.position = newPosition;

        dragOrigin = Input.mousePosition;
    }
}
