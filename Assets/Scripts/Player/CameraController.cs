using UnityEngine;

public class CameraController : MonoBehaviour {
    #region Serialize Values
    [Header("Player Parts")]
    [SerializeField]
    private Transform playerBody;
    [SerializeField]
    private Transform playerHead;

    [Header("Camera")]
    [SerializeField]
    private Camera cam;
    [SerializeField]
    private Transform camPoint;

    [Header("action Values")]
    [SerializeField]
    private float maxCameraDistance = 5f;
    [SerializeField]
    private float cameraDistance;
    [SerializeField]
    private float mouseSensitivity = 2f;
    private float lerpSpeed = 6f;
    [SerializeField]
    private float minVerticalAngle, maxVerticalAngle;
    [SerializeField]
    private float currentRotX;
    public RaycastHit[] casted;
    
    [Header("Cast")]
    [SerializeField]
    private LayerMask collisionLayer;
    #endregion

    #region Private Values
    Vector2 _mouseInput;
    #endregion
    void LateUpdate() {
        cameraDistance = maxCameraDistance;

        cameraDistance = CheckCameraCollision();

        camPoint.transform.localPosition = new Vector3(0, 0, -cameraDistance);
        cam.transform.position = Vector3.Lerp(cam.transform.position, camPoint.transform.position, lerpSpeed * Time.deltaTime);
        cam.transform.rotation = Quaternion.Lerp(cam.transform.rotation, camPoint.transform.rotation, lerpSpeed * Time.deltaTime);

        MouseRotate();
    }

    void MouseRotate() {
        _mouseInput.x = Input.GetAxis("Mouse X") * mouseSensitivity;
        _mouseInput.y = Input.GetAxis("Mouse Y") * mouseSensitivity;

        currentRotX = Mathf.Clamp(currentRotX - _mouseInput.y, minVerticalAngle, maxVerticalAngle);

        playerBody.Rotate(Vector3.up * _mouseInput.x);
        playerHead.localRotation = Quaternion.Euler(currentRotX, 0, 0);
    }

    float CheckCameraCollision() {
        casted = new RaycastHit[5];
        Ray ray = new Ray();
        ray.direction = -playerHead.forward;
        ray.origin = playerHead.position;

        int count = Physics.RaycastNonAlloc(ray, casted, maxCameraDistance, collisionLayer);

        if (count > 0) {
            RaycastHit close = casted[0];

            return close.distance - 0.1f;
        }

        return maxCameraDistance;
    }

    void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(playerBody.transform.position + new Vector3(0, 1), camPoint.transform.forward * (cameraDistance + 1) + new Vector3(0, 1));
    }
}