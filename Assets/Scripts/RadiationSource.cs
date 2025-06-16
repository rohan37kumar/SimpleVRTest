using UnityEngine;

public class RadiationSource : MonoBehaviour
{
    public RadiationData radiationData;
    private bool isDetectorInRange = false;

    private void OnTriggerEnter(Collider other)
    {
        DetectorMechanism detector = other.GetComponent<DetectorMechanism>();
        if (detector != null && !isDetectorInRange)
        {
            isDetectorInRange = true;
            DetectorMechanism.BroadcastRadiationDetection(radiationData);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        DetectorMechanism detector = other.GetComponent<DetectorMechanism>();
        if (detector != null && isDetectorInRange)
        {
            isDetectorInRange = false;
            DetectorMechanism.BroadcastRadiationDetection(null);
        }
    }
}