using UnityEngine;
public class FollowVRSetupUI : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset = Vector3.zero;


    private void LateUpdate()
    {
        if (target == null) return;

        Vector3 targetPosition = target.position + offset;

        // Instantly update position
        transform.position = targetPosition;
    }

}
