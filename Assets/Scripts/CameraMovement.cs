using UnityEngine;

public class CameraMovement : MonoBehaviour {
    [SerializeField] private float sensitivity = 1f;
    [SerializeField] private float xMin = -90, xMax = 90, yMin = -90, yMax = 90;

    private float xRot;
    private float yRot;

    private void Update() {
        if (Input.GetMouseButton(1)) {
            Cursor.lockState = CursorLockMode.Locked;
            xRot = Mathf.Clamp(xRot + sensitivity * Input.GetAxis("Mouse X"), xMin, xMax);
            yRot = Mathf.Clamp(yRot - sensitivity * Input.GetAxis("Mouse Y"), yMin, yMax);

            transform.rotation = Quaternion.Euler(yRot, xRot, 0);
        }
        else {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}