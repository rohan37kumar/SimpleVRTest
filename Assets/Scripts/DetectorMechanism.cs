using UnityEngine;
using System;

public class DetectorMechanism : MonoBehaviour
{
    public static event Action<RadiationData> OnRadiationDetected;
    private bool isInRadiationField = false;
    [SerializeField] private Vector3 defaultPosition;

    private void Start()
    {
        transform.position = defaultPosition;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Radiation"))
        {
            RadiationSource source = other.GetComponent<RadiationSource>();
            if (source != null && !isInRadiationField)
            {
                isInRadiationField = true;
                OnRadiationDetected?.Invoke(source.radiationData);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Radiation"))
        {
            RadiationSource source = other.GetComponent<RadiationSource>();
            if (source != null && isInRadiationField)
            {
                isInRadiationField = false;
                OnRadiationDetected?.Invoke(null);
            }
        }
    }
}
