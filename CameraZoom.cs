using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public float zoomSpeed = 5f;
    public float minZoom = 1f;
    public float maxZoom = 10f;

    void Update()
    {
        float scrollValue = Input.GetAxis("Mouse ScrollWheel");

        // �ӹǳ��ë��
        float newZoom = Camera.main.orthographicSize - scrollValue * zoomSpeed * Time.deltaTime;

        // �ӡѴ�ͺࢵ�ͧ��ë��
        newZoom = Mathf.Clamp(newZoom, minZoom, maxZoom);

        // ��˹���ҡ�ë�����Ѻ Camera
        Camera.main.orthographicSize = newZoom;
    }
}
