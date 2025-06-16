using UnityEngine;
public class FollowVRSetupUI : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset = Vector3.zero;
    [SerializeField] private Camera vrCamera;


    private void LateUpdate()
    {
        if (target == null) return;

        Vector3 targetPosition = target.position + offset;

        // Instantly update position
        transform.position = targetPosition;
        Vector3 lookDir = transform.position - vrCamera.transform.position;
        transform.rotation = Quaternion.LookRotation(lookDir, Vector3.up);
    }

}
