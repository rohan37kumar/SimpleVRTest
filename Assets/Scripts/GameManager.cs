using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI radiationDisplayText;
    private AudioSource radiationAudioSource;

    private void Start()
    {
        radiationAudioSource = gameObject.GetComponent<AudioSource>();
        radiationAudioSource.loop = true;
        radiationAudioSource.playOnAwake = false;
    }

    private void OnEnable()
    {
        DetectorMechanism.OnRadiationDetected += HandleRadiationDetection;
    }

    private void OnDisable()
    {
        DetectorMechanism.OnRadiationDetected -= HandleRadiationDetection;
    }

    private void HandleRadiationDetection(RadiationData radiationData)
    {
        if (radiationDisplayText != null)
        {
            if (radiationData == null)
            {
                radiationDisplayText.text = "No Radiation Detected";
                if (radiationAudioSource.isPlaying)
                {
                    radiationAudioSource.Stop();
                }
            }
            else
            {
                radiationDisplayText.text = $"Detected: {char.ToUpper(radiationData.typeIdentifier[0]) + radiationData.typeIdentifier.Substring(1)} Radiation";

                if (radiationData.radiationSound != null)
                {
                    radiationAudioSource.clip = radiationData.radiationSound;
                    radiationAudioSource.Play();
                }
            }
            Debug.Log($"Radiation Display Updated: {radiationDisplayText.text}");
        }
    }
}
