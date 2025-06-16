using UnityEngine;
using System;

public class DetectorMechanism : MonoBehaviour
{
    public static event Action<RadiationData> OnRadiationDetected;
    [SerializeField] private Vector3 defaultPosition;

    private void Start()
    {
        transform.position = defaultPosition;
    }

    public static void BroadcastRadiationDetection(RadiationData data)
    {
        Debug.Log("radiation detected");
        OnRadiationDetected?.Invoke(data);
    }
}
